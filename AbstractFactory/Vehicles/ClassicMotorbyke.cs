using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Vehicles
{
    public class ClassicMotorbyke : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Classic motorbyke speeding up...");
        }
        public void Break()
        {
            Console.WriteLine("Classic motorbyke breaking...");
        }
    }
}
