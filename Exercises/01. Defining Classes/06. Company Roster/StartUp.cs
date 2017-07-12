using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Company_Roster
{
    class StartUp
    {
        static void Main()
        {
            var numberOfEmployees = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();
           
            for (int i = 0; i < numberOfEmployees; i++)
            {
                var emoloyeeInfo = Console.ReadLine().Split(' ');

                var employee = new Employee(
                            emoloyeeInfo[0],
                            decimal.Parse(emoloyeeInfo[1]),
                            emoloyeeInfo[2],
                            emoloyeeInfo[3] );
                if (emoloyeeInfo.Length > 4)
                {
                    if (int.TryParse(emoloyeeInfo[4], out int age))
                    {
                        employee.Age = age;
                    }
                    else
                    {
                        employee.Email = emoloyeeInfo[4];
                    }
                }
                if (emoloyeeInfo.Length > 5)
                {
                    employee.Age = int.Parse(emoloyeeInfo[5]);
                }
                employees.Add(employee);
            }
            var depart = employees.GroupBy(em => em.Department)
                .Select(gr => new
                {
                    Name = gr.Key,
                    AverageSalary = gr.Average(em => em.Salary),
                    Employee = gr
                })
                .OrderByDescending(gr => gr.AverageSalary)
                .FirstOrDefault();
            Console.WriteLine($"Highest Average Salary: {depart.Name}");
            foreach (var emp in depart.Employee.OrderByDescending(em => em.Salary))
            {
                Console.WriteLine(emp.PrintEmployeeInfo());
            }
        }
    }
}
