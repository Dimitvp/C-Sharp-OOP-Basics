using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data
{
    class StartUp
    {
        static void Main()
        {
            var numbersOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < numbersOfCars; i++)
            {
                var carInfo = Console.ReadLine().Split();

                var model = carInfo[0];
                var engine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
                var cargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);
                var tires = new Tire[]
                {
                    new Tire(double.Parse(carInfo[5]), int.Parse(carInfo[6])),
                    new Tire(double.Parse(carInfo[7]), int.Parse(carInfo[8])),
                    new Tire(double.Parse(carInfo[9]), int.Parse(carInfo[10])),
                    new Tire(double.Parse(carInfo[11]), int.Parse(carInfo[12]))
                };

                var car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            var command = Console.ReadLine();
            if (command == "fragile")
            {
                var result = cars.Where(c => c.Cargo.Type == "fragile" && c.Tire.Any(x => x.Pressure < 1));
                foreach (var car in result)
                {
                    Console.WriteLine(car);
                }
            }
            else if (command == "flamable")
            {
                var result = cars.Where(c => c.Cargo.Type == "flamable").Where(ep => ep.Engine.Power > 250);
                foreach (var car in result)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
