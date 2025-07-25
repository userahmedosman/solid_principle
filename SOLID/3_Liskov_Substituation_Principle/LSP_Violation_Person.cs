using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_Liskov_Substituation_Principle
{
    public class LSP_Violation_Person
    {
        public virtual void PaySalary()
        {
            Console.WriteLine("Paying salary...");

        }

        public virtual void SendEmail()
        {
            Console.WriteLine("Sending Email..");
        }
    }

    public class Employee: LSP_Violation_Person
    {
        public override void PaySalary()
        {
            Console.WriteLine("Paying salary to employee.");
        }
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to employee..");
        }
    }

    public class Student : LSP_Violation_Person
    {
        public override void PaySalary()
        {
            Console.WriteLine("Error: Student can't get salary");
        }
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to student..");
        }
    }

    public class Manager : LSP_Violation_Person
    {
        public override void PaySalary()
        {
            Console.WriteLine("Paying salary to manager.");
        }
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to manager..");
        }
    }
}
