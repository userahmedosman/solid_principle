using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_Interface_Segregation_Principle
{

    interface IPrint
    {
        void Print(string text);
    }

    interface IFax
    {
        void Fax();
    }

    interface IScan
    {
        void Scan();
    }
    public class ISP_Basic_Printer : IPrint
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

    public class ISP_Advanced_Printer : IPrint, IFax, IScan
    {
        public void Fax()
        {
            Console.WriteLine("Fax sent sucessfully");
        }

        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void Scan()
        {
            Console.WriteLine("Scanner started service");
        }
    }
}
