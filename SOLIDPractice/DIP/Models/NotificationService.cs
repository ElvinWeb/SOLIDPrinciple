using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Models
{
    internal class NotificationService
    {
        private readonly IMessageSender _messageSender;

        public NotificationService(IMessageSender messageSender)
        {
            _messageSender = messageSender;
        }

        public void SendNotification(string message)
        {
            _messageSender.SendMessage(message);
        }
    }
}
