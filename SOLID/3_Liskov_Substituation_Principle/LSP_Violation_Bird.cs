using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_Liskov_Substituation_Principle
{
    public class LSP_Violation_Bird
    {

        public virtual void Fly()
        {
            Console.WriteLine("Flying..");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Eating..");
        }
    }

    public class Eagle: LSP_Violation_Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Eagle is Flying...");
        }

        public override void Eat()
        {
            Console.WriteLine("Eagle is Eating...");
        }
    }



    public class Ostrich: LSP_Violation_Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Ostrich is Eating");
        }

        public override void Fly()
        {
            new Exception("Ostrich can't Fly");
        }
    }
}
