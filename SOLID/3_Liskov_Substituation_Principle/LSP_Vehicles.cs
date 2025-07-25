using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_Liskov_Substituation_Principle
{
    public class LSP_Vehicle
    {
     
        public virtual void Drive()
        {
            Console.WriteLine("Driving..");
        }
    }

    public class MotorVehicle: LSP_Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Engine started..");
        }
    }
   

    public class LSP_Car : MotorVehicle
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



    public class LSP_Bicycle : LSP_Vehicle
    {

        public override void Drive()
        {
            new Exception("Riding the bicycle");
        }
    }
}
