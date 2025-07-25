using SOLID._2_Open_Closed_Principle;
using SOLID._2_Open_Closed_Principle.SOLID._2_Open_Closed_Principle;
using SOLID._3_Liskov_Substituation_Principle;
using SOLID._4_Interface_Segregation_Principle;
using SOLID._5_Dependency_Invertion_Principle;
using static SOLID._2_Open_Closed_Principle.Notification_Service_OCP;


namespace SOLID
{
    public class Program
    {

    public static void Main()
        {
            // Single Responcipility Principle

            ////Notification_Service Notification_Service = new Notification_Service();
            //Notification_Service_SRP Notification_Service = new Notification_Service_SRP();

            //// Send an email
            //Notification_Service.SendNotification("john@example.com", "Welcome to our service!", Notification_Service_SRP.enNotificationType.Email);
            //// Send an SMS
            //Notification_Service.SendNotification("+123456789", "Your OTP code is 1234.", Notification_Service_SRP.enNotificationType.SMS);

            //// Send a fax
            //Notification_Service.SendNotification("123-456-789", "Fax Message: Important document.", Notification_Service_SRP.enNotificationType.Fax);

            //Logging_Service logging_Service = new Logging_Service();
            //logging_Service.SendErrorLog("Error to file", Logging_Service.enLogService.File);
            //logging_Service.SendErrorLog("Error to database", Logging_Service.enLogService.Database);
            //logging_Service.SendErrorLog("Error to eventLog", Logging_Service.enLogService.EventLog);

            //Logging_Service_SRP srp = new Logging_Service_SRP();
            //srp.SendErrorLog("Error from SRP to file", Logging_Service_SRP.enLogService.File);
            //srp.SendErrorLog("Error from SRP to database", Logging_Service_SRP.enLogService.Database);
            //srp.SendErrorLog("Error from SRP to eventLog", Logging_Service_SRP.enLogService.EventLog);

            // Open/Closed Principle

            //Notification_Service_OCP email = new Notification_Service_OCP(new OCP_EmailService());
            // email.SendNotification("mail@gmail.com", "Sending you email");
            // Notification_Service_OCP fax = new Notification_Service_OCP(new OCP_FaxService());
            // fax.SendNotification("259-223-866-147", "Sending you fax");
            // Notification_Service_OCP sms = new Notification_Service_OCP(new OCP_SMSService());
            // sms.SendNotification("+9488250111", "Sending you SMS");
            // Notification_Service_OCP telegram = new Notification_Service_OCP(new OCP_TelegramService());
            // telegram.SendNotification("@username", "Sending you telegram");

            //Logging_Service_ORB tofile = new Logging_Service_ORB(new ToFile_OCP());
            //tofile.SendErrorLog("Logging error to file");
            //Logging_Service_ORB todatabase = new Logging_Service_ORB(new ToDatabase_OCP());
            //todatabase.SendErrorLog("Logging error to Database");
            //Logging_Service_ORB toeventlog = new Logging_Service_ORB(new ToEventLog_OCP());
            //toeventlog.SendErrorLog("Logging error to EventLog");
            //Logging_Service_ORB toexcellog = new Logging_Service_ORB(new ToExcel_OCP());
            //toeventlog.SendErrorLog("Logging error to Excel");

            //Payment_Service_OCP payment = new Payment_Service_OCP(new PayPal());
            //payment.ProcessPayment(250, "payment processed using PayPal");

            //payment = new Payment_Service_OCP(new CreditCard());
            //payment.ProcessPayment(1200, "payment processed using CreditCard");

            //payment = new Payment_Service_OCP(new BitCoin());
            //payment.ProcessPayment(590, "payment processed using BitCoin");

            //payment = new Payment_Service_OCP(new BankTransfer());
            //payment.ProcessPayment(2900, "payment processed using BankTransfer");


            // Liskov Substituation Principle

            //Eagle eagle = new Eagle();
            //eagle.Fly();
            //eagle.Eat();

            //Ostrich ostrich = new Ostrich();
            ////ostrich.Fly(); // will raise exception
            //ostrich.Eat();

            // Interface Segregation Principle

            //IPrinter basicPrinter = new Basic_Printer();
            //basicPrinter.Print("Printing: This is basic printer");
            ////basicPrinter.Fax(); // will raise exception
            ////basicPrinter.Scan(); // will raise exception

            //IPrinter advancedPrinter = new Advanced_Printer();
            //advancedPrinter.Print("Printing: This is advanced printer");
            //advancedPrinter.Fax();
            //advancedPrinter.Scan(); 


            // Dependency Invertion Principle

            //var report = new DIP_Report(new pdfReport()); // Dependency Injection Design pattern
            //report.GenerateReport();

            //report = new DIP_Report(new wordReport());
            //report.GenerateReport();

            //report = new DIP_Report(new CrystalReport());
            //report.GenerateReport();
        }
    }
}
