using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_Interface_Segregation_Principle
{

    interface IChannel
    {
        void ChangeChannel();
    }

    interface IMail
    {
        void SendEmail();
    }

    interface ISms
    {
        void SendSms();
    }

    interface ICall
    {
        void MakeCall();
    }


    public class ISP_SmartPhone : ICall, ISms, IMail
    {
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

    public class ISP_TV : IChannel
    {
        public void ChangeChannel()
        {
            Console.WriteLine("Channel Changed..");
        }
    }

    public class ISP_PC : IMail
    {
        public void SendEmail()
        {
            Console.WriteLine("PC Sending email..");
        }
    }
}
