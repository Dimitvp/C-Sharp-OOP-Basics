using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Exercise
{
    static class Spaces
    {
        public static string enginepropsspaces = new string(' ', 4);
        public static string carpropsspaces = new string(' ', 2);
    }
    class Program
    {


        static void Main(string[] args)
        {

            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();
            int enginecount = int.Parse(Console.ReadLine());
            for (int i = 0; i < enginecount; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                string enginepower = tokens[1];
                string powerdispl = string.Empty;
                string effic = string.Empty;

                if (tokens.Length == 3)
                {
                    if (tokens[2].All(x => Char.IsDigit(x)))
                    {
                        powerdispl = tokens[2];
                    }
                    else
                    {
                        effic = tokens[2];
                    }
                }
                if (tokens.Length == 4)
                {
                    powerdispl = tokens[2];
                    effic = tokens[3];
                }


                engines.Add(new Engine(model, enginepower, powerdispl, effic));
            }
            int carcount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carcount; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                var engine = engines.FirstOrDefault(x => x.EngineModel == tokens[1]);
                string weigth = String.Empty;
                string color = string.Empty;
                if (tokens.Length == 3)
                {
                    if (tokens[2].All(x => Char.IsDigit(x)))
                    {
                        weigth = tokens[2];
                    }
                    else
                    {
                        color = tokens[2];
                    }
                }
                if (tokens.Length == 4)
                {
                    weigth = tokens[2];
                    color = tokens[3];
                }
                cars.Add(new Car(name, engine, weigth, color));
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }

    class Car
    {
        private Engine engine;
        public string Model { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public Engine Engine
        {
            get { return engine; }
            private set { engine = value; }
        }

        public Car(string model, Engine engine, string weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = string.IsNullOrEmpty(weight) ? "n/a" : weight;
            Color = string.IsNullOrEmpty(color) ? "n/a" : color;
        }

        public override string ToString()
        {
            return Model + ":" + "\n" + Engine.ToString() + "\n" + Spaces.carpropsspaces + "Weight: " + Weight + "\n" + Spaces.carpropsspaces + "Color: " + Color;


        }
    }

    class Engine
    {
        public string EngineModel { get; set; }
        public string PowerDisplacement { get; set; }
        public string Efficiency { get; set; }
        public string EnginePower { get; set; }

        public Engine(string enginemodel, string enginepower, string powerdispl, string efficiency)
        {
            EngineModel = enginemodel;
            PowerDisplacement = string.IsNullOrEmpty(powerdispl) ? "n/a" : powerdispl;
            Efficiency = string.IsNullOrEmpty(efficiency) ? "n/a" : efficiency;
            EnginePower = enginepower;
        }

        public override string ToString()
        {
            return Spaces.carpropsspaces + EngineModel + ":" + "\n" + Spaces.enginepropsspaces + "Power: " + EnginePower + "\n" + Spaces.enginepropsspaces + "Displacement: " +
                   PowerDisplacement + "\n" + Spaces.enginepropsspaces + "Efficiency: " + Efficiency;
        }
    }

}

//using System;
//using System.Collections.Generic;
//using System.Text;
////Грешката е открита. Този идиот си вкарва колите в речник, а не в лист.

//public class Controller
//{
//    public static void Main()
//    {
//        var incomingEngines = int.Parse(Console.ReadLine());
//        var engines = new Dictionary<string, Engine>();
//        for (int i = 0; i < incomingEngines; i++)
//        {
//            var engineInfo = Console.ReadLine().Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
//            var model = engineInfo[0];
//            var power = double.Parse(engineInfo[1]);
//            if (engineInfo.Length == 2)
//            {
//                engines.Add(model, new Engine(model, power));
//                continue;
//            }
//            var displacement = 0.0;
//            var efficiency = string.Empty;
//            if (engineInfo.Length == 3)
//            {
//                if (double.TryParse(engineInfo[2], out displacement))
//                {
//                    engines.Add(model, new Engine(model, power, displacement));
//                    continue;
//                }
//                else
//                {
//                    efficiency = engineInfo[2];
//                    engines.Add(model, new Engine(model, power, efficiency));
//                    continue;
//                }
//            }
//            else
//            {
//                displacement = double.Parse(engineInfo[2]);
//                efficiency = engineInfo[3];
//                engines.Add(model, new Engine(model, power, displacement, efficiency));
//            }
//        }
//        var incomingCars = int.Parse(Console.ReadLine());
//        var cars = new Dictionary<string, Car>();
//        for (int i = 0; i < incomingCars; i++)
//        {
//            var carInfo = Console.ReadLine().Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
//            var model = carInfo[0];
//            var engineName = carInfo[1];
//            var curEngine = engines[engineName];
//            if (carInfo.Length == 2)
//            {
//                cars.Add(model, new Car(model, curEngine));
//                continue;
//            }
//            var weight = 0.0;
//            var color = string.Empty;
//            if (carInfo.Length == 3)
//            {
//                if (double.TryParse(carInfo[2], out weight))
//                {
//                    cars.Add(model, new Car(model, curEngine, weight));
//                    continue;
//                }
//                else
//                {
//                    color = carInfo[2];
//                    cars.Add(model, new Car(model, curEngine, color));
//                    continue;
//                }
//            }
//            else
//            {
//                weight = double.Parse(carInfo[2]);
//                color = carInfo[3];
//                cars.Add(model, new Car(model, curEngine, weight, color));
//            }
//        }
//        //foreach (var car in cars)
//        //{
//        //    Console.WriteLine(car.Value.ToString());
//        //}
//    }
//}


//using System;
//using System.Text;

//public class Car
//{
//    public Car(string model, Engine engine, double weight) : this(model, engine, weight, null)
//    { }
//    public Car(string model, Engine engine, string color) : this(model, engine, 0, color)
//    { }
//    public Car(string model, Engine engine) : this(model, engine, 0, null)
//    { }
//    public Car(string model, Engine engine, double weight, string color)
//    {
//        this.Model = model;
//        this.Engine = engine;
//        this.Weight = weight;
//        this.Color = color;
//    }
//    private string model;
//    private Engine engine;
//    private double weight;
//    private string color;

//    public string Model
//    {
//        get
//        {
//            return this.model;
//        }
//        private set
//        {
//            this.model = value;
//        }
//    }
//    public Engine Engine
//    {
//        get
//        {
//            return this.engine;
//        }
//        private set
//        {
//            this.engine = value;
//        }
//    }
//    public double Weight
//    {
//        get
//        {
//            return this.weight;
//        }
//        private set
//        {
//            this.weight = value;
//        }
//    }
//    public string Color
//    {
//        get
//        {
//            return this.color;
//        }
//        private set
//        {
//            this.color = value;
//        }
//    }

//    public override string ToString()
//    {
//        var sb = new StringBuilder();
//        sb.Append($"{this.Model}:{Environment.NewLine}  {this.Engine.ToString()}");
//        if (this.Weight != 0)
//        {
//            sb.Append($"{Environment.NewLine}  Weight: {this.Weight}");
//        }
//        else
//        {
//            sb.Append($"{Environment.NewLine}  Weight: n/a");
//        }
//        if (this.Color != null)
//        {
//            sb.Append($"{Environment.NewLine}  Color: {this.Color}");
//        }
//        else
//        {
//            sb.Append($"{Environment.NewLine}  Color: n/a");
//        }
//        return sb.ToString();
//    }
//}
//using System;
//using System.Text;

//public class Engine
//{
//    public Engine(string model, double power, double displacement) : this(model, power, displacement, null)
//    { }
//    public Engine(string model, double power, string efficiency) : this(model, power, 0, efficiency)
//    { }
//    public Engine(string model, double power) : this(model, power, 0, null)
//    { }
//    public Engine(string model, double power, double displacement, string efficiency)
//    {
//        this.Model = model;
//        this.Power = power;
//        this.Displacement = displacement;
//        this.Efficiency = efficiency;
//    }
//    private string model;
//    private double power;
//    private double displacement;
//    private string efficiency;

//    public string Model
//    {
//        get
//        {
//            return this.model;
//        }
//        set
//        {
//            this.model = value;
//        }
//    }
//    public double Power
//    {
//        get
//        {
//            return this.power;
//        }
//        set
//        {
//            this.power = value;
//        }
//    }
//    public double Displacement
//    {
//        get
//        {
//            return this.displacement;
//        }
//        set
//        {
//            this.displacement = value;
//        }
//    }
//    public string Efficiency
//    {
//        get
//        {
//            return this.efficiency;
//        }
//        set
//        {
//            this.efficiency = value;
//        }
//    }
//    public override string ToString()
//    {
//        var sb = new StringBuilder();
//        sb.Append($"{this.Model}:{Environment.NewLine}    Power: {this.Power}");
//        if (this.Displacement != 0)
//        {
//            sb.Append($"{Environment.NewLine}    Displacement: {this.Displacement}");
//        }
//        else
//        {
//            sb.Append($"{Environment.NewLine}    Displacement: n/a");
//        }
//        if (this.Efficiency != null)
//        {
//            sb.Append($"{Environment.NewLine}    Efficiency: {this.Efficiency}");
//        }
//        else
//        {
//            sb.Append($"{Environment.NewLine}    Efficiency: n/a");
//        }
//        return sb.ToString();
//    }
//}