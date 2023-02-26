using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Security.Cryptography;
using System.Text;

namespace JBQQuizMe.ViewModel.Providers
{
    /// <summary>
    /// Provider for sending email communications from application
    /// </summary>
    public class EmailProvider
    {
        private readonly ICryptoTransform _decryptor;

        private readonly string _x6Nd5hSWLuB5;
        private readonly string _x9GnZb7PBKs4;

        /// <summary>
        /// Constructor
        /// </summary>
        public EmailProvider()
        {
            var x63TKBqcW6Pa = Preferences.Default.Get("bf362ddb-713f-46e6-9c7d-d620f40766c6", (string)null);

            using (var aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(x63TKBqcW6Pa);
                aes.IV = new byte[16];
                _decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
            }

            _x6Nd5hSWLuB5 = Preferences.Default.Get("4ad5e9b5-4dca-4c5e-991a-b5bed2c123ec", (string)null);
            _x9GnZb7PBKs4 = Preferences.Default.Get("19e32c9e-9e3c-4707-b537-6f8c0cdc1d93", (string)null);
        }

        /// <summary>
        /// Send a message
        /// </summary>
        /// <param name="toEmailAddr">To address</param>
        /// <param name="subject">Subject</param>
        /// <param name="message">Message</param>
        /// <exception cref="ArgumentNullException">Invalid arguments were provided</exception>
        public async Task SendAsync(string toEmailAddr, string subject, MimeEntity message)
        {
            if(string.IsNullOrEmpty(toEmailAddr))
            {
                throw new ArgumentNullException(nameof(toEmailAddr), "An email address must be provided");
            }
            if (string.IsNullOrEmpty(subject))
            {
                throw new ArgumentNullException(nameof(subject), "An email subject must be provided");
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message), "An email messsage must be provided");
            }

            if(_x6Nd5hSWLuB5 == null || _x9GnZb7PBKs4 == null)
            {
                throw new InvalidOperationException("Supporting data missing");
            }

            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(DecryptString(_x6Nd5hSWLuB5)));
            email.To.Add(MailboxAddress.Parse(toEmailAddr));
            email.Subject = subject;
            email.Body = message;

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(DecryptString(_x6Nd5hSWLuB5), DecryptString(_x9GnZb7PBKs4));
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }

        private string DecryptString(string cipherText)
        {
            byte[] buffer = Convert.FromBase64String(cipherText);

            using var memoryStream = new MemoryStream(buffer);
            using var cryptoStream = new CryptoStream(memoryStream, _decryptor, CryptoStreamMode.Read);
            using var streamReader = new StreamReader(cryptoStream);

            return streamReader.ReadToEnd();
        }
    }
}
