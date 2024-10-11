using PdfiumViewer;
using System;
using System.Windows.Forms;

namespace DocumentTemplater
{
    public partial class MainForm : Form
    {
        Templates.Template template;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFile_btn_Click(object sender, EventArgs e)
        {
            using (var opf = new OpenFileDialog() { Filter = "Все файлы *.*|*.*|Документ Word *.docx|*.docx" })
            {
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    template = Templates.Template.GetTemplateFromFileName(System.IO.Path.GetExtension(opf.FileName));
                    if (template == null)
                    {
                        MessageBox.Show("Указанный документ не является доступным к заполнению шаблону.");
                        return;
                    }
                }
            }
        }

        private void SaveFile_btn_Click(object sender, EventArgs e)
        {

        }

        private void SendFile_btn_Click(object sender, EventArgs e)
        {

        }

        private void PreviewFile_btn_Click(object sender, EventArgs e)
        {
            var pdfDocument = PdfDocument.Load(template.FileName);

            var printDocument = pdfDocument.CreatePrintDocument();
            using (var dia = new PrintPreviewDialog())
            {
                dia.Document = printDocument;
                dia.ShowDialog();
            }
        }
    }
}
