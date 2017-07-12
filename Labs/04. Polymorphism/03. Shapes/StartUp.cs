using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Shapes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(5);

            Console.WriteLine(circle.CalculatePerimeter());
            Console.WriteLine(circle.CalculateArea());
        }
    }
}
