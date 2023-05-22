using AbstractFactory.Interfaces;
using AbstractFactory.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class ClassicFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new ClassicCar();
        }

        public IVehicle CreateMotorbyke()
        {
            return new ClassicMotorbyke();
        }
    }
}
