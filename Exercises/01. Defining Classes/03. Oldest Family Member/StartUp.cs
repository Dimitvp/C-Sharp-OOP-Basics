using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03.Oldest_Family_Member
{
    class StartUp
    {
        static void Main(string[] args)
        {
            MethodInfo oldestMemdMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemdMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemdMethod == null || addMemdMethod == null)
            {
                throw new Exception();
            }

            var personName = string.Empty;
            var personAge = 0;
            var family = new Family();

            int numOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPeople; i++)
            {
                var inputTokens = Console.ReadLine().Split(' ').ToArray(); 
                personName = inputTokens[0];
                personAge = int.Parse(inputTokens[1]);

                var person = new Person(personName, personAge);
                
                family.AddMember(person);
            }

            var oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
