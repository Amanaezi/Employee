using System;
using System.Collections.Generic;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Security() { Name = "Petro", Rank = 500 });
            employees.Add(new Manager() { Name = "Ivan", Rank = 200, Bonus = 0.01, SalesVolume = 1000000 });
            employees.Add(new Ceo() { Name = "Fedir Ivanovych", Rank = 600, Bonus = 0.005, SalesVolume = 18000000 });

            foreach(var empl in employees)
            {
                Console.WriteLine($"{empl.Name} got {empl.GetSalary(30)}");
            }
        }
    }
}
