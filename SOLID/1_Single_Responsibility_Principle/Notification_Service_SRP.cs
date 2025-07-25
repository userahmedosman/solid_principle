using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLID.Single_Responsibility_Principle.Notification_Service;

namespace SOLID.Single_Responsibility_Principle
{
    public class Notification_Service_SRP
    {
        public enum enNotificationType { Email, SMS, Fax }
        public void SendNotification(string to, string message, enNotificationType NotificationType)
        {

            if (NotificationType == enNotificationType.Email)
            {
                EmailService.SendEmail(to, message);
            }
            else if (NotificationType == enNotificationType.SMS)
            {
                SMSService.SendSMS(to, message);
            }
            else if (NotificationType == enNotificationType.Fax)
            {
                FaxService.SendFax(to, message);
            }
        }
    }

    public class EmailService
    {
        // Method to send Fax
        public static void SendEmail(string to, string message)
        {
            Console.WriteLine($"\nSending Email to {to}: {message}");
        }
    }

    public class SMSService
    {
        // Method to send SMS
        public static void SendSMS(string to, string message)
        {
            Console.WriteLine($"\nSending SMS to {to}: {message}");
        }
    }

    public class FaxService
    {
        // Method to send Fax
        public static void SendFax(string to, string message)
        {
            Console.WriteLine($"\nSending Fax to {to}: {message}");
        }
    }
}
