using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_Interface_Segregation_Principle
{

    interface IPrinter
    {
        void Print(string content);
        void Scan();

        void Fax();
    }
    public class Basic_Printer : IPrinter
    {

        public void Print(string content)
        {
            Console.WriteLine(content);
        }

        public void Fax()
        {
            throw new Exception("Basic printer does not support Fax service");
        }

        public void Scan()
        {
            throw new Exception("Basic printer does not support Scan service");
        }
    }


    public class Advanced_Printer : IPrinter
    {
        public void Fax()
        {
            Console.WriteLine("Fax sent successfully");
        }

        public void Print(string content)
        {
            Console.WriteLine(content);
        }

        public void Scan()
        {
            Console.WriteLine("Scanning started successfully");
        }
    }
}
