using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static _05_classes.Vehicle;

namespace _05_classes
{



    [TestClass]
    public class VehicleTests
    {




        [TestMethod]
        public void PropertiesTest()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.make = "Nissan";
            firstVehicle.model = "Centra";
            firstVehicle.mileage = 50000;
            firstVehicle.VehicleTypes = VehicleTypes.car;

            Console.WriteLine($"I have a {firstVehicle.make} {firstVehicle.model} it has {firstVehicle.mileage} miles on it. it is a {firstVehicle.VehicleTypes}.");



        }

        [TestMethod]
        public void EngineTest()
        {

            Vehicle transport = new Vehicle();
            transport.TurnOn();
            Console.WriteLine(transport.IsRunning);
            transport.TurnOff();
            transport.Drive();

            transport.RightIndicator = new Indicator();
            transport.LeftIndicator = new Indicator();

            transport.IndicateLeft();
            Console.WriteLine("Indicating left");
            CheckIndicators(transport);

            transport.IndicateRight();
            Console.WriteLine("Turning right");
            CheckIndicators(transport);

            transport.TurnOnHazards();
            Console.WriteLine("Oh no an accident");
            CheckIndicators(transport);

        }

        [TestMethod]
        public void Constructors()
        {
            Vehicle car = new Vehicle();
            car.make = "Toyota";
            car.model = "Corolla";
            car.mileage = 21300;
            car.VehicleTypes = VehicleTypes.car;

            Console.WriteLine($"{car.make} {car.model}");

            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 30000, VehicleTypes.spaceship);
            Console.WriteLine($"{rocket.make} {rocket.model} is a {rocket.VehicleTypes}");
        }

        // Helper method
        private void CheckIndicators(Vehicle vehicle)
        {
            Console.WriteLine($"Right indicator: {vehicle.RightIndicator.IsFlashing}");
            Console.WriteLine($"Left indicator: {vehicle.LeftIndicator.IsFlashing}");
        }


    }
}
