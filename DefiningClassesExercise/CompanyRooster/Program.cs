using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System.Text.RegularExpressions;

namespace CompanyRooster
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee>employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                decimal salary = decimal.Parse(input[1]);
                var position = input[2];
                var department = input[3];
                var email = string.Empty;
                int Age = 0;
               
                try
                {
                    var check = input[4].ToCharArray();
                    Match match = Regex.Match(input[4][0].ToString(), @"[0-9]");
                    Match emailmatch = Regex.Match(input[4][0].ToString(), @"[A-Za-z]");
                    if (match.Success)
                    {
                        Age = int.Parse(input[4]);
                        email = "n/a";
                    }
                    else if(emailmatch.Success)
                    {
                        email = input[4];
                    }
                }
                catch (Exception)
                {

                }
                try
                {
                    Age = int.Parse(input[5]);
                }
                catch (Exception)
                {
                    if (Age>0)
                    {
                       
                    }
                    else
                    {
                        Age = -1;
                    }
                    
                }
                if (email == "")
                {
                    email = "n/a";
                }

                var employee = new Employee()
                {
                    Name = name,
                    Salary = salary,
                    Position = position,
                    Department = department,
                    Email = email,
                    Age = Age
                };

                employees.Add(employee);
            }
            var dep = employees.GroupBy(x => x.Department, x => x.Salary).OrderByDescending(x => x.Average()).First();
            Console.WriteLine($"Highest Average Salary: {dep.Key}");
            foreach (var employee in employees.Where(e => e.Department == dep.Key).OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
