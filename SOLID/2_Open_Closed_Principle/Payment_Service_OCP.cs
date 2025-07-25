using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_Open_Closed_Principle
{
    public class Payment_Service_OCP
    {
        private readonly IPayment _payment;
        public Payment_Service_OCP(IPayment payment)
        {
            this._payment = payment;
        }

        public void ProcessPayment(decimal amount, string message)
        {
            _payment.PaymentService(amount, message);
        }

    }

    public interface IPayment
    {
        void PaymentService(decimal amount, string message);
    }

    public class PayPal : IPayment
    {
        public void PaymentService(decimal amount, string message)
        {
            Console.WriteLine(amount + "$ " + message);
        }
    }

    public class BitCoin:IPayment
    {
        public void PaymentService(decimal amount, string message)
        {
            Console.WriteLine(amount + "$ " + message);
        }
    }

    public class CreditCard:IPayment
    {
        public void PaymentService(decimal amount, string message)
        {
            Console.WriteLine(amount + "$ " + message);
        }
    }

    public class BankTransfer:IPayment
    {
        public void PaymentService(decimal amount, string message)
        {
            Console.WriteLine(amount + "$ " + message);
        }
    }
}
