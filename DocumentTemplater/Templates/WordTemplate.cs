using Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.IO;

namespace DocumentTemplater.Templates
{
    /// <summary>
    /// Шаблон документа в Word.
    /// </summary>
    internal class WordTemplate : Template
    {
        private Application _application;
        private Document _document;

        public override string FileName { get; }

        /// <inheritdoc cref="WordTemplate"/>
        /// <param name="fileName"> Путь к документу.</param>
        public WordTemplate(string fileName)
        {
            FileName = fileName;
            _application = new Application();
            _document = _application.Documents.Open(FileName);
        }

        /// <inheritdoc/>
        public override IEnumerable<string> GetNameBookmarks()
        {
            if (string.IsNullOrEmpty(FileName) || !File.Exists(FileName))
            {
                throw new FileNotFoundException("Документ по указанному пути не найден.");
            }

            var nameBookmarks = new List<string>();
            foreach (Bookmark bookmark in _document.Bookmarks)
            {
                nameBookmarks.Add(bookmark.Name);
            }
            return nameBookmarks;
        }

        /// <inheritdoc/>
        public override void SaveAs(string pathToSave)
        {
            _document.SaveAs(pathToSave);
        }

        /// <inheritdoc/>
        public override void CloseDocument()
        {
            _document.Close();
            _application.Quit();
        }

        /// <inheritdoc/>
        public override void RefreshValuesBookmarks(Dictionary<string, string> dictionaryBookmarks)
        {
            foreach (var dictionaryBookmark in dictionaryBookmarks)
            {
                if (_document.Bookmarks[dictionaryBookmark.Key] is Bookmark bookmark)
                {
                    bookmark.Range.Text = dictionaryBookmark.Value;
                }
            }
        }
    }
}
