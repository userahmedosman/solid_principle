using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_Interface_Segregation_Principle
{

    interface IDevice
    {
        void MakeCall();
        void ChangeChannel();

        void SendEmail();

        void SendSms();
    }
    public class SmartPhone : IDevice
    {
        public void ChangeChannel()
        {
            throw new Exception("Not Supported");
        }

        public void MakeCall()
        {
            Console.WriteLine("Calling: +1 235 1455 113");
        }

        public void SendEmail()
        {
            Console.WriteLine("Phone Sending email..");
        }

        public void SendSms()
        {
            Console.WriteLine("Sending SMS..");
        }
    }

    public class TV: IDevice
    {
        public void ChangeChannel()
        {
            Console.WriteLine("Channel Changed..");
        }

        public void MakeCall()
        {
            throw new Exception("Not Supported");
        }

        public void SendEmail()
        {
            throw new Exception("Not Supported");
        }

        public void SendSms()
        {
            throw new Exception("Not Supported");
        }
    }

    public class PC : IDevice
    {
        public void ChangeChannel()
        {
            throw new Exception("Not Supported");
        }

        public void MakeCall()
        {
            throw new Exception("Not Supported");
        }

        public void SendEmail()
        {
            Console.WriteLine("PC Sending email..");
        }

        public void SendSms()
        {
            throw new Exception("Not Supported");
        }
    }
}
