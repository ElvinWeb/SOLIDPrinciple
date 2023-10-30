using DIP.Models;

namespace DIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessageSender emailSender = new EmailSender();
            IMessageSender smsSender = new SMSSender();

            NotificationService emailNotificationService = new NotificationService(emailSender);
            NotificationService smsNotificationService = new NotificationService(smsSender);

            emailNotificationService.SendNotification("Email has already sended the user");
            smsNotificationService.SendNotification("SMS has already sended the user");
        }
    }
}