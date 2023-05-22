using AbstractFactory.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IVehicleFactory
    {
        IVehicle CreateCar();
        IVehicle CreateMotorbyke();
    }
}
