using MailKit.Net.Smtp;
using MimeKit;

namespace Esamsat.Repositories.Implementations
{
    public class EmailService
    {
        private readonly string _smtpServer = "smtp.gmail.com"; // ganti sesuai provider
        private readonly int _smtpPort = 587;
        private readonly string _smtpUser = "ikhlasulamal445@gmail.com";
        private readonly string _smtpPass = "ixnt xsfy uuzx fvgo";

        public async Task KirimEmailAsync(string penerima, string subject, string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_smtpUser));
            email.To.Add(MailboxAddress.Parse(penerima));
            email.Subject = subject;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_smtpServer, _smtpPort, MailKit.Security.SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_smtpUser, _smtpPass);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
    }
}
