using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_Liskov_Substituation_Principle
{
    public class LSP_Violation_Vehicles
    {

        public virtual void StartEngine()
        {
            Console.WriteLine("Engine started..");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Driving..");
        }
    }

    public class Car : LSP_Violation_Vehicles
    {
        public override void StartEngine()
        {
            Console.WriteLine("Eagle is Flying...");
        }

        public override void Drive()
        {
            Console.WriteLine("Driving the car...");
        }
    }



    public class Bicycle : LSP_Violation_Vehicles
    {
        public override void StartEngine()
        {
            Console.WriteLine("Error: Bicycle doesn't have an engine");
        }

        public override void Drive()
        {
            new Exception("Riding the bicycle");
        }
    }
}
