using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Single_Responsibility_Principle
{
    public class Notification_Service
    {
        public enum enNotificationType { Email, SMS, Fax }

        public void SendNotification(string to, string message, enNotificationType NotificationType)
        {

            if (NotificationType == enNotificationType.Email)
            {
                SendEmail(to, message);
            }
            else if (NotificationType == enNotificationType.SMS)
            {
                SendSMS(to, message);
            }
            else if (NotificationType == enNotificationType.Fax)
            {
                SendFax(to, message);
            }
        }
        // Method to send email
        private void SendEmail(string to, string message)
        {
            Console.WriteLine($"\nSending Email to {to}: {message}");
        }

        // Method to send SMS
        private void SendSMS(string to, string message)
        {
            Console.WriteLine($"\nSending SMS to {to}: {message}");
        }

        // Method to send Fax
        private void SendFax(string to, string message)
        {
            Console.WriteLine($"\nSending Fax to {to}: {message}");
        }
    }
}
