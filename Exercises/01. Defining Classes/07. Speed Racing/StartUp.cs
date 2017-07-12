using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Speed_Racing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            var num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var inputLine = Console.ReadLine().Split();
                var model = inputLine[0];
                var fuelAmmaunt = int.Parse(inputLine[1]);
                var fuelConsumption = double.Parse(inputLine[2]);

                var car = new Car(model, fuelAmmaunt, fuelConsumption);
                cars.Add(car);
            }
            string inputCommands;
            while ((inputCommands = Console.ReadLine()) != "End")
            {
                var comands = inputCommands.Split();
                var carModel = comands[1];
                var amaunOfKm = int.Parse(comands[2]);

                Car currentCar = cars.Where(c => c.Model == carModel).ToList().First();
                currentCar.IsMove(amaunOfKm);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.Distance}");
            }
        }
    }
}
