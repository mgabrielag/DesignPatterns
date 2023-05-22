using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Vehicles
{
    public class EsportiveCar : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Esportive car speeding up...");
        }
        public void Break()
        {
            Console.WriteLine("Esportive car breaking...");
        }

    }
}
