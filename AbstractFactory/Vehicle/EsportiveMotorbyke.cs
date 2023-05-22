using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Vehicles
{
    public class EsportiveMotorbyke : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Esportive motorbyke speeding up...");
        }
        public void Break()
        {
            Console.WriteLine("Esportive motorbyke breaking...");
        }
    }
}
