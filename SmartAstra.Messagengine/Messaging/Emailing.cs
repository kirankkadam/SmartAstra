using SendGrid;
using SendGrid.Helpers.Mail;
using SmartAstra.Framework.Entities.Interfaces;
using System.Threading.Tasks;

namespace SmartAstra.Messagengine
{
    public class Emailing : Messaging
    {
        public Emailing(IMessage message) : base(message)
        {

        }

        public async override Task<int> SendMessage(IMessage message)
        {
            var sendGridClientOptions = new SendGridClientOptions();
            sendGridClientOptions.ApiKey = "";
            sendGridClientOptions.Host = "";
            var smtpClient = new SendGridClient(sendGridClientOptions);
            // smtpClient.(ServerSettings.SmtpServerName, Convert.ToInt32(ServerSettings.SmtpPort), ServerSettings.IsSecureSocket ? SecureSocketOptions.SslOnConnect : SecureSocketOptions.None);
            //smtpClient.Authenticate(ServerSettings.SmtpUsername, ServerSettings.SmtpPassword);
            var email = CreateMessage();
            var response = await smtpClient.SendEmailAsync(email);
            if (response.IsSuccessStatusCode)
            {
                return await Task.Run(() => 1);
            }
            return await Task.Run(() => 0);
        }

        private SendGridMessage CreateMessage()
        {
            var email = new SendGridMessage()
            {
                From = new EmailAddress()
                {
                    Email = "kirankkadam@gmail.com",
                    Name = "Kiran Kadam"
                },
                Subject = "Test email",
                HtmlContent = "<strong>Hello dude~!!!</strong>"
            };

            email.AddTo("kirankkadam@yahoo.com", "Kiran Kadam");

            var trackingSettings = new TrackingSettings()
            {
                ClickTracking = new ClickTracking() { Enable = true },
                OpenTracking = new OpenTracking() { Enable = true },
                SubscriptionTracking = new SubscriptionTracking() { Enable = true },
                Ganalytics = new Ganalytics() { Enable = true }
            };

            email.TrackingSettings = trackingSettings;

            return email;
        }
    }
}
