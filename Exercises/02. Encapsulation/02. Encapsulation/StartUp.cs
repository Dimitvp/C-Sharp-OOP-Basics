using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02.Encapsulation
{
    class StartUp
    {
        static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());
            
            var lenght = double.Parse(Console.ReadLine());
            var widht = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var box = new Box(lenght, widht, height);

            Console.WriteLine($"Surface Area - {box.GetSurfaceArea():f2}");
            Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():f2}");
            Console.WriteLine($"Volume - {box.GetVolume():f2}");
        }
    }
}
