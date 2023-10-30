using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Models
{
    public class SMSSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
