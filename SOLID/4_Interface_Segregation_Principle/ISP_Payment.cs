using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_Interface_Segregation_Principle
{

    interface ICreditCardPayment
    {
        void CreditCardPay();
    }

    interface IBitCoinPayment
    {
        void BitCoinPay();
    }

    interface IPayPalPayment
    {
        void PayPalPay();
    }
    public class ISP_CreditCard_Payment : ICreditCardPayment
    {

        public void CreditCardPay()
        {
            Console.WriteLine("CreditCard payment done");
        }


    }


    public class ISP_BitCoin_Payment: IBitCoinPayment
    {
        public void BitCoinPay()
        {
            Console.WriteLine("BitCoin payment done");
        }

    }

    public class ISP_PayPal_Payment: IPayPalPayment
    {

        public void PayPalPay()
        {
            Console.WriteLine("PayPal payment done");
        }
    }

}
