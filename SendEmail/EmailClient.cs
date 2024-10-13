using System.Net.Mail;
using System.Net;
using SendEmail.Interfaces;

namespace SendEmail
{
    /// <summary>
    /// Почтовый клиент.
    /// </summary>
    public class EmailClient : ISender
    {
        /// <summary>
        /// SMTP-клиент для отправки писем.
        /// </summary>
        private readonly SmtpClient _smtpClient;

        /// <inheritdoc cref="EmailClient"/>
        /// <param name="host"> Адрес хоста почтового домена.</param>
        /// <param name="port"> Порт для подключения к хосту.</param>
        /// <param name="email"> Адрес электронной почты пользователя.</param>
        /// <param name="password"> Пароль электронной почты пользователя.</param>
        /// <param name="isEnableSsl"> Отправка по протоколу SSL.</param>
        public EmailClient(string host, int port, string email, string password, bool isEnableSsl = false)
        {
            _smtpClient = new SmtpClient(host)
            {
                Port = port,
                Credentials = new NetworkCredential(email, password),
                EnableSsl = isEnableSsl
            };
        }

        /// <inheritdoc/>
        public void SendMessage(string[] emailsTo, string subject, string body, params string[] attachments)
        {
            // Создаем письмо для отравки.
            var message = new MailMessage()
            {
                From = new MailAddress((_smtpClient.Credentials as NetworkCredential).UserName), 
                Subject = subject, 
                Body = body
            };

            // Заполняем список получателей.
            foreach (var emailTo in emailsTo)
            {
                message.To.Add(new MailAddress(emailTo));
            }

            // Заполняет список вложений.
            foreach (var attachment in attachments)
            {
                message.Attachments.Add(new Attachment(attachment));
            }

            // Отправка письма.
            _smtpClient.SendMailAsync(message);
        }
    }
}
