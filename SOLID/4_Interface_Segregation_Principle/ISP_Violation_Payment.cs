using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_Interface_Segregation_Principle
{
    interface IPayment
    {
        void CreditCardPay();
        void BitCoinPay();
        void PayPalPayment();
    }
    public class CreditCard_Payment : IPayment
    {
        public void BitCoinPay()
        {
            throw new Exception("UnSupported");
        }

        public void CreditCardPay()
        {
            Console.WriteLine("CreditCard payment done");
        }

        public void PayPalPayment()
        {
            throw new Exception("UnSupported");
        }
    }


    public class BitCoin_Payment
    {
        public void BitCoinPay()
        {
            Console.WriteLine("BitCoin payment done");
        }

        public void CreditCardPay()
        {
            throw new Exception("UnSupported");
        }

        public void PayPalPayment()
        {
            throw new Exception("UnSupported");
        }
    }
}

    public class PayPal_Payment
    {
    public void BitCoinPay()
    {
        throw new Exception("UnSupported");
    }

    public void CreditCardPay()
    {
        throw new Exception("UnSupported");
    }

    public void PayPalPayment()
    {
        Console.WriteLine("PayPal payment done");
    }

    
}
