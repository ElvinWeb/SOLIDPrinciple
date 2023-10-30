using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Models
{
    class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }
}
