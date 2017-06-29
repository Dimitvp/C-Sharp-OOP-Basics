using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03.Oldest_Family_Member
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var personName = string.Empty;
            var personAge = 0;
            var over30 = new Over30();
           

            int numOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPeople; i++)
            {
                var inputTokens = Console.ReadLine().Split(' ').ToArray(); 
                personName = inputTokens[0];
                personAge = int.Parse(inputTokens[1]);

                var person = new Person(personName, personAge);
                if (personAge > 30)
                {
                    over30.AddMember(person);
                }
                
            }
            
            foreach (var p in over30.Members.OrderBy(m => m.Name))
            {
                Console.WriteLine($"{p.Name} - {p.Age}");
            }
        }
    }
}
