using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skip = input[0];
            int take = input[1];
            string input2 = Console.ReadLine();
            string regex = @"(?<=\|<).{0," + skip + @"}(.{0," + take + @"})(?=\||\b)";
            var words = Regex.Matches(input2, regex);
            List<string> output = new List<string>();
            foreach (Match w in words)
            {
                output.Add(w.Groups[1].Value);
            }
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
