using AbstractFactory.Factories;
using AbstractFactory.Interfaces;
using AbstractFactory.Vehicles;

int chosenVehicle;
IVehicleFactory esportiveVehicleFactory = new EsportiveFactory();
IVehicleFactory classicVehicleFactory = new ClassicFactory();
IVehicle vehicle;


Console.WriteLine("Choose a vehicle: \n 1 - Esportive Car \n 2 - Esportive Motorbyke \n 3 - Classic Car \n 4 - Classic Motorbyke");
chosenVehicle = int.Parse(Console.ReadLine());

switch (chosenVehicle)
{
    case 1:
        vehicle = esportiveVehicleFactory.CreateCar();
        break;
    case 2:
        vehicle = esportiveVehicleFactory.CreateMotorbyke();
        break;
    case 3:
        vehicle = classicVehicleFactory.CreateCar();
        break;
    case 4:
        vehicle = classicVehicleFactory.CreateMotorbyke();
        break;
    default:
        throw new ArgumentException("Choose a valid vehicle.");
}

vehicle.Accelerate();
vehicle.Break();
