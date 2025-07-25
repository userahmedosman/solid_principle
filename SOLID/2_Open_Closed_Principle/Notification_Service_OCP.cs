using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_Open_Closed_Principle
{
    public class Notification_Service_OCP
    {
        private readonly INotificationService _notificationService;

        public Notification_Service_OCP(INotificationService notificationService)
        {
            this._notificationService = notificationService;
        }

        public void SendNotification(string to, string message)
        {

           _notificationService.Send(to, message);
        }

        public interface INotificationService
        {
            void Send(string to, string message);
        }

        public class OCP_EmailService:INotificationService
        {
            // Method to send Fax
            public  void Send(string to, string message)
            {
                Console.WriteLine($"\nSending Email to {to}: {message}");
            }
        }

        public class OCP_SMSService : INotificationService
        {
            // Method to send SMS
            public  void Send(string to, string message)
            {
                Console.WriteLine($"\nSending SMS to {to}: {message}");
            }
        }

        public class OCP_FaxService : INotificationService
        {
            // Method to send Fax
            public  void Send(string to, string message)
            {
                Console.WriteLine($"\nSending Fax to {to}: {message}");
            }
        }

        //Adding new Telegram Service using a traditional way
        public class OCP_TelegramService : INotificationService
        {
            // Method to send Telegram
            public  void Send(string to, string message)
            {
                Console.WriteLine($"\nSending Telegram to {to}: {message}");
            }

        }

    }
}