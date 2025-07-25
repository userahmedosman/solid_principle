using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_Liskov_Substituation_Principle
{
    public class LSP_Bird
    {
        public virtual void Eat()
        {
            Console.WriteLine("Eating");
        }
    }

    public class FlyingBirds: LSP_Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("Flying..");
        }
    }

    public class LSP_Eagle: FlyingBirds
    {
        public override void Fly()
        {
            Console.WriteLine("The Eagle is Flying..");
        }
        public override void Eat()
        {
            Console.WriteLine("The Eagle is Eating..");
        }
    }


    public class LSP_Ostrich : LSP_Bird {
        public override void Eat()
        {
            Console.WriteLine("The Ostrich is Eating..");
        }
    }
}
