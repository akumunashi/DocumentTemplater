namespace SendEmail.Interfaces
{
    /// <summary>
    /// Методы для отправителя.
    /// </summary>
    public interface ISender
    {
        /// <summary>
        /// Отправить письмо.
        /// </summary>
        /// <param name="emailsTo"> Список почт получателей.</param>
        /// <param name="subject"> Тема письма.</param>
        /// <param name="body"> Текстовое содержимое письма.</param>
        /// <param name="attachments"> Список вложенией.</param>
        void SendMessage(string[] emailsTo, string subject, string body, params string[] attachments);
    }
}
