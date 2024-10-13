using System.Collections.Generic;

namespace DocumentTemplater.Templates
{
    /// <summary>
    /// Шаблон документа.
    /// </summary>
    abstract class Template
    {
        /// <summary>
        /// Путь к документу.
        /// </summary>
        public abstract string FileName { get; }

        /// <summary>
        /// Сохранить документ по указанному пути.
        /// </summary>
        /// <param name="pathToSave"> Путь к документу для сохранения.</param>
        public abstract void SaveAs(string pathToSave);

        /// <summary>
        /// Получить имена закладок в документе.
        /// </summary>
        public abstract IEnumerable<string> GetNameBookmarks();

        /// <summary>
        /// Обновить значения закладок в документе перед сохранением.
        /// </summary>
        /// <param name="dictionaryBookmarks"> Словарь закладок и их значений.</param>
        public abstract void RefreshValuesBookmarks(Dictionary<string, string> dictionaryBookmarks);

        /// <summary>
        /// Закрыть документ.
        /// </summary>
        public abstract void CloseDocument();

        /// <summary>
        /// Получить шаблон документа из пути к файлу.
        /// </summary>
        /// <param name="fileName"> Путь к файлу.</param>
        /// <returns> Шаблон документа.</returns>
        public static Template GetTemplateFromFileName(string fileName)
        {
            var extension = System.IO.Path.GetExtension(fileName);
            switch (extension)
            {
                case ".docx": return new WordTemplate(fileName);
                default: return null;
            }
        }
    }
}
