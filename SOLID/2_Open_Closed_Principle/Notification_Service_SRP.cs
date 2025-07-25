using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_Open_Closed_Principle
{
    public class Notification_Service_SRP
    {
        public enum enNotificationType { Email, SMS, Fax, Telegram }
        public void SendNotification(string to, string message, enNotificationType NotificationType)
        {

            if (NotificationType == enNotificationType.Email)
            {
                EmailService.Send(to, message);
            }
            else if (NotificationType == enNotificationType.SMS)
            {
                SMSService.Send(to, message);
            }
            else if (NotificationType == enNotificationType.Fax)
            {
                FaxService.Send(to, message);
            }
            else if (NotificationType == enNotificationType.Telegram)
            {
                FaxService.Send(to, message);
            }
        }
    }

    public class EmailService
    {
        // Method to send Fax
        public static void Send(string to, string message)
        {
            Console.WriteLine($"\nSending Email to {to}: {message}");
        }
    }

    public class SMSService
    {
        // Method to send SMS
        public static void Send(string to, string message)
        {
            Console.WriteLine($"\nSending SMS to {to}: {message}");
        }
    }

    public class FaxService
    {
        // Method to send Fax
        public static void Send(string to, string message)
        {
            Console.WriteLine($"\nSending Fax to {to}: {message}");
        }
    }

    //Adding new Telegram Service using a traditional way
    public class TelegramService
    {
        // Method to send Telegram
        public static void Send(string to, string message)
        {
            Console.WriteLine($"\nSending Telegram to {to}: {message}");
        }
    }
}
