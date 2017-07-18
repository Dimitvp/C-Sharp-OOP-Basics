using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Polymorphism
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var vehicleData = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
            var fuelQuantity = double.Parse(vehicleData[1]);
            var litersPerKm = double.Parse(vehicleData[2]);
            var tankCapacity = double.Parse(vehicleData[3]);
            var car = new Car(fuelQuantity, litersPerKm, tankCapacity);

            vehicleData = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
            fuelQuantity = double.Parse(vehicleData[1]);
            litersPerKm = double.Parse(vehicleData[2]);
            tankCapacity = double.Parse(vehicleData[3]);
            var truck = new Truck(fuelQuantity, litersPerKm, tankCapacity);

            vehicleData = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
            fuelQuantity = double.Parse(vehicleData[1]);
            litersPerKm = double.Parse(vehicleData[2]);
            tankCapacity = double.Parse(vehicleData[3]);
            var bus = new Bus(fuelQuantity, litersPerKm, tankCapacity);

            var events = int.Parse(Console.ReadLine());

            for (int i = 0; i < events; i++)
            {
                var currentEventData = Console.ReadLine().Split(new char[] { ' ' }).ToArray();
                var currnetEvent = currentEventData[0];
                var vehicleType = currentEventData[1];
                Vehicle vehicle;
                if (vehicleType == "Car")
                {
                    vehicle = car;
                }
                else if (vehicleType == "Truck")
                {
                    vehicle = truck;
                }
                else
                {
                    vehicle = bus;
                }
                var data = double.Parse(currentEventData[2]);
                switch (currnetEvent)
                {
                    case "Drive":
                        Drive(vehicle, data);
                        break;
                    case "Refuel":
                        Refuel(vehicle, data);
                        break;
                    case "DriveEmpty":
                        DriveEmpty(bus, data);
                        break;
                }
            }

            Console.WriteLine($"Car: {car.Fuel:f2}");
            Console.WriteLine($"Truck: {truck.Fuel:f2}");
            Console.WriteLine($"Bus: {bus.Fuel:f2}");
    }
        private static void DriveEmpty(Bus bus, double distance)
        {
            try
            {
                Console.WriteLine(bus.DriveEmpty(distance));
            }
            catch (ApplicationException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
        private static void Refuel(Vehicle vehicle, double amounth)
        {

            try
            {
                vehicle.Refuel(amounth);

            }
            catch (ApplicationException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }

        private static void Drive(Vehicle vehicle, double distance)
        {
            try
            {
                Console.WriteLine(vehicle.Drive(distance));
            }
            catch (ApplicationException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
