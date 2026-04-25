using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_DoanTuanKiet_2331200057
{
    internal class NotificationService
    {
        public virtual void SendNotification(string message)
        {
            Console.WriteLine("Sending notification: " + message); 
        }

        public virtual void SendNotification(string message, string recipient)
        {
            Console.WriteLine("Sending notification to {0}: {1}", recipient, message);
        }

        public virtual void SendNotification(string message, List<string> recipients)
        {
            Console.WriteLine("Sending notification to {0} recipients: {1}", recipients.Count, message);
        }

        //Exercise 10
        public void EmailSendNotification(Book book, Member member)
        {
            Console.WriteLine("Sending email notification to {0} about the book '{1}'", member.name, book.title);
        }

        public void SMSNotification(Book book, Member member)
        {
            Console.WriteLine("Sending SMS notification to {0} about the book '{1}'", member.name, book.title);
        }

    }
}
