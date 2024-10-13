using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using SendEmail;
using Database;
using DocumentTemplater.Logging;
using DocumentTemplater.Interfaces;
using Database.Domain;

namespace DocumentTemplater
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Активный шаблон документа.
        /// </summary>
        private Templates.Template _template;

        /// <summary>
        /// Логгирование операций пользователя.
        /// </summary>
        private ILogger _logger;

        public MainForm()
        {
            InitializeComponent();
            var databaseConnection = new DatabaseConnection<Log>();
            _logger = new Logger(databaseConnection);
        }

        /// <summary>
        /// Открыть документ.
        /// </summary>
        private void OpenFile_btn_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog() { Filter = "Документ Word *.docx|*.docx" })
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    _logger.Log("OpenFile_btn_Click", $"Загрузка документа: {fileDialog.FileName}", DateTime.UtcNow);
                    try
                    {
                        LoadDocument(fileDialog.FileName);
                        _logger.Log("OpenFile_btn_Click", $"Успешно загружен документ: {fileDialog.FileName}", DateTime.UtcNow);
                    }
                    catch (Exception ex)
                    {
                        _logger.Log("OpenFile_btn_Click", $"Ошибка при попытке загрузки документа: {fileDialog.FileName}. {ex.Message}", DateTime.UtcNow);
                    }
                }
            }
        }

        /// <summary>
        /// Загрузить шаблон документа по указанному пути.
        /// </summary>
        /// <param name="fileName"> Путь к документу.</param>
        private void LoadDocument(string fileName)
        {
            // Закрываем активный документ и очищаем панель.
            CloseDocument();

            // Получаем шаблон по указанному пути.
            _template = Templates.Template.GetTemplateFromFileName(fileName);
            // Получаем имена закладок и создаем поля для заполнения на форме.
            var nameBookmarks = _template.GetNameBookmarks();
            foreach (var nameBookmark in nameBookmarks)
            {
                flowLayoutPanel1.Controls.Add(new GroupWithField(nameBookmark));
            }
        }

        /// <summary>
        /// Закрыть активный документ и удалить поля для заполнения.
        /// </summary>
        private void CloseDocument()
        {
            // Закрываем активный документ.
            _template?.CloseDocument();
            // Очищаем существующие поля для заполнения.
            flowLayoutPanel1.Controls.Clear();
        }

        /// <summary>
        /// Получить словарь из названий закладок и их значений.
        /// </summary>
        /// <returns> Словарь из названий закладок и их значений.</returns>
        private Dictionary<string, string> GetDictionaryBookmarks()
        {
            var dictionaryBookmarks = new Dictionary<string, string>();
            foreach (GroupWithField field in flowLayoutPanel1.Controls)
            {
                dictionaryBookmarks.Add(field.NameBookmark, field.ValueBookmark);
            }

            return dictionaryBookmarks;
        }

        /// <summary>
        /// Сохранить документ по указанному пути.
        /// </summary>
        private void SaveFile_btn_Click(object sender, EventArgs e)
        {
            // Сообщаем о невозможности сохранить документ, если документ не выбран.
            if (_template == null)
            {
                MessageBox.Show("Не выбран документ для сохранения.");
                _logger.Log("SaveFile_btn_Click", "Неудачная попытка сохранения документа. Документ для сохранения не выбран.", DateTime.UtcNow);
                return;
            }

            // Получаем путь к файлу для сохранения.
            var pathToSave = string.Empty;
            using (var fileDialog = new SaveFileDialog() { Filter = "Документ Word *.docx|*.docx" })
            {
                if (fileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                pathToSave = fileDialog.FileName;
            }
            // Создаем словарь из закладок и их значений.
            var dictionaryBookmarks = GetDictionaryBookmarks();
            // Обновляем значения закладок в документе.
            _template.RefreshValuesBookmarks(dictionaryBookmarks);
            // Сохраняем документ по указанному пути.
            _template.SaveAs(pathToSave);
            // Обновляем шаблон документ.
            _template = Templates.Template.GetTemplateFromFileName(_template.FileName);
            _logger.Log("SaveFile_btn_Click", $"Сохранение документа: {pathToSave}", DateTime.UtcNow);
        }

        /// <summary>
        /// Отправить документ по электронной почте.
        /// </summary>
        private void SendFile_btn_Click(object sender, EventArgs e)
        {
            // Сообщаем о невозможности сохранить документ, если документ не выбран.
            if (_template == null)
            {
                MessageBox.Show("Не выбран документ для отправки на электронную почту.");
                _logger.Log("SendFile_btn_Click", "Неудачная попытка отправки документа. Документ для отправки не выбран.", DateTime.UtcNow);
                return;
            }

            // Создаем словарь из закладок и их значений.
            var dictionaryBookmarks = GetDictionaryBookmarks();
            // Обновляем значения закладок в шаблоне.
            _template.RefreshValuesBookmarks(dictionaryBookmarks);

            // Сохраняем файл во временную папку для последующей его отправки.
            var tempFileName = Path.GetTempPath() + Path.GetFileName(_template.FileName);
            _template.SaveAs(tempFileName);
            // Отправляем документ из временной папки и удаляем его.
            _logger.Log("SendFile_btn_Click", $"Отправка документа по электронной почте: {_template.FileName}", DateTime.UtcNow);
            SendEmail(tempFileName);
            File.Delete(tempFileName);
        }

        /// <summary>
        /// Отправить документ на указанную почту.
        /// </summary>
        /// <param name="pathToSend"> Путь к документу для отправки.</param>
        public void SendEmail(string pathToSend)
        {
            try
            {
                var emailClient = new EmailClient("smtp.yandex.ru", 465, "sender@yandex.ru", "password", true);
                emailClient.SendMessage(new string[] { "recipient@yandex.ru" }, "Документы", "Отправляю документы.", pathToSend);
                _logger.Log("SendEmail", $"Документ {_template.FileName} отправлен на электронную почту: recipient@yandex.ru", DateTime.UtcNow);
            }
            catch (Exception ex)
            {
                _logger.Log("SendEmail", $"Документ {_template.FileName} не удалось отправить на электронную почту: recipient@yandex.ru. {ex.Message}", DateTime.UtcNow);
            }
        }

        /// <summary>
        /// Закрыть активный документ после закрытия окна формы.
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseDocument();
        }
    }
}
