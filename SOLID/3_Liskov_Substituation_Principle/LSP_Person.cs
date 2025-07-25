using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_Liskov_Substituation_Principle
{
    public class LSP_Person
    {
       
        public virtual void SendEmail()
        {
            Console.WriteLine("Sending Email..");
        }
    }

    public class PersonWithJob: LSP_Person
    {
        public virtual void PaySalary()
        {
            Console.WriteLine("Paying salary...");

        }

    }

    public class LSP_Employee : PersonWithJob
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

    public class LSP_Student : LSP_Person
    {
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to student..");
        }
    }

    public class LSP_Manager : PersonWithJob 
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
