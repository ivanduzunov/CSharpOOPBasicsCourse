using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var peopleList = new List<Person>();
            var input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var personName = tokens[0];
                if (!peopleList.Any(p => p.Name == personName))
                {
                    Person person = new Person(personName);
                    peopleList.Add(person);
                }
                if (tokens[1] == "company")
                {
                    peopleList.Where(p => p.Name == personName).First().Company
                        = new Company(tokens[2], tokens[3], double.Parse(tokens[4]));
                }
                else if (tokens[1] == "car")
                {
                    peopleList.Where(p => p.Name == personName).First().Car
                        = new Car(tokens[2], tokens[3]);
                }
                else if (tokens[1] == "children")
                {
                    peopleList.Where(p => p.Name == personName).First().Children
                        .Add(new Child(tokens[2], tokens[3]));
                }
                else if (tokens[1] == "parents")
                {
                    peopleList.Where(p => p.Name == personName).First().Parents
                        .Add(new Parent(tokens[2], tokens[3]));
                }
                else if (tokens[1] == "pokemon")
                {
                    peopleList.Where(p => p.Name == personName).First().Pokemons
                        .Add(new Pokemon(tokens[2], tokens[3]));
                }
            }

            var printName = Console.ReadLine();

            peopleList.Where(p => p.Name == printName).First().Print();
        }
    }
}
