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
        /// Загрузить документ.
        /// </summary>
        public abstract void Load();

        /// <summary>
        /// Сохранить документ.
        /// </summary>
        public abstract void Save();

        /// <summary>
        /// Предпросмотр в PDF.
        /// </summary>
        public abstract void PdfPreview();

        public static Template GetTemplateFromFileName(string fileName)
        {
            var extension = System.IO.Path.GetExtension(fileName);
            switch (extension)
            {
                case ".docx": return new WordTemplate();
                default: return null;
            }
        }
    }
}
