using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person()
                {
                    Name = name,
                    Age = age
                };

                people.Add(person);
            }

            var result = people.Where(p => p.Age > 30).ToList();

            foreach (var person in result.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
