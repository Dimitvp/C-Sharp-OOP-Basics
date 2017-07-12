using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Mordor_s_Cruelty_Plan
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<FoodFactory> food = new List<FoodFactory>();

            string[] input = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //string[] input = "Cram melon honeyCake Cake".ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var item in input)
            {
                switch (item)
                {
                    //Cram: 2 points of happiness;
                    case "cram":
                        food.Add(new Cram());
                        break;

                    //Lembas: 3 points of happiness;
                    case "lembas":
                        food.Add(new Lembas());
                        break;

                    //Apple: 1 point of happiness;
                    case "apple":
                        food.Add(new Apple());
                        break;

                    //Melon: 1 point of happiness;
                    case "melon":
                        food.Add(new Melon());
                        break;

                    //HoneyCake: 5 points of happiness;
                    case "honeycake":
                        food.Add(new HoneyCake());
                        break;

                    //Mushrooms: -10 points of happiness;
                    case "mushrooms":
                        food.Add(new Mushrooms());
                        break;

                    //Everything else: -1 point of happiness;
                    default:
                        food.Add(new Else());
                        break;
                }
            }
            Console.WriteLine(food.Sum(x => x.Points));
            Console.WriteLine(new Mood(food.Sum(x => x.Points)));
        }
    }
}
