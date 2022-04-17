
using MailKit.Net.Smtp;
using MimeKit;
using Project.Class;
using System.Configuration;

namespace Project
{
    public class Email
    {
        public static string host = ConfigurationManager.AppSettings["host"];
        public static int smtpport = int.Parse(ConfigurationManager.AppSettings["port"]);
        public static string username = ConfigurationManager.AppSettings["username"];
        public static string password = ConfigurationManager.AppSettings["password"];

        public static async Task ServisEmail(User user, string status, Services servis)
        {
            using MimeMessage msg = new MimeMessage();

            msg.From.Add(new MailboxAddress("no-reply", "motorbike.servis@email.cz"));

            msg.To.Add(new MailboxAddress($"{user.FirstName} {user.LastName}", user.Email));

            msg.Subject = "Informace o Servisu";

            BodyBuilder builder = new BodyBuilder();

            builder.HtmlBody = File.ReadAllText("Assets/servis_email_template.html");

            builder.HtmlBody = builder.HtmlBody.Replace("__NAME__", $"{user.FirstName} {user.LastName}");
            builder.HtmlBody = builder.HtmlBody.Replace("__motorbikebrand__", servis.Brand);
            builder.HtmlBody = builder.HtmlBody.Replace("__motorbikemodel__", servis.Model);
            builder.HtmlBody = builder.HtmlBody.Replace("__STATUS__", status);

            msg.Body = builder.ToMessageBody();

            using SmtpClient client = new SmtpClient();

            await client.ConnectAsync(host, smtpport, true);
            await client.AuthenticateAsync(username, password);

            await client.SendAsync(msg);

            await client.DisconnectAsync(true);
        }

        public static async Task RegisterEmail(User user)
        {
            using MimeMessage msg = new MimeMessage();

            msg.From.Add(new MailboxAddress("no-reply", "motorbike.servis@email.cz"));

            msg.To.Add(new MailboxAddress($"{user.FirstName} {user.LastName}", user.Email));

            msg.Subject = "Informace o Registraci";

            BodyBuilder builder = new BodyBuilder();

            builder.HtmlBody = File.ReadAllText("Assets/register_email_template.html");

            builder.HtmlBody = builder.HtmlBody.Replace("__NAME__", $"{user.FirstName} {user.LastName}");

            msg.Body = builder.ToMessageBody();

            using SmtpClient client = new SmtpClient();

            await client.ConnectAsync(host, smtpport, true);
            await client.AuthenticateAsync(username, password);

            await client.SendAsync(msg);

            await client.DisconnectAsync(true);
        }

        public static async Task OrderEmail(User user, float totalPrice)
        {
            using MimeMessage msg = new MimeMessage();

            msg.From.Add(new MailboxAddress("no-reply", "motorbike.servis@email.cz"));

            msg.To.Add(new MailboxAddress($"{user.FirstName} {user.LastName}", user.Email));

            msg.Subject = "Informace o Servisu";

            BodyBuilder builder = new BodyBuilder();

            builder.HtmlBody = File.ReadAllText("Assets/order_email_template.html");

            builder.HtmlBody = builder.HtmlBody.Replace("__NAME__", $"{user.FirstName} {user.LastName}");
            builder.HtmlBody = builder.HtmlBody.Replace("__PRICE__", totalPrice.ToString());

            msg.Body = builder.ToMessageBody();

            using SmtpClient client = new SmtpClient();

            await client.ConnectAsync(host, smtpport, true);
            await client.AuthenticateAsync(username, password);

            await client.SendAsync(msg);

            await client.DisconnectAsync(true);
        }
    }
}
