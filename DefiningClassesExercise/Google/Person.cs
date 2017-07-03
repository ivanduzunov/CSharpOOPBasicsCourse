using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    public class Person
    {

        private string name;
        private Company company;
        private Car car;
        private List<Parent> parents;
        private List<Child> children;
        private List<Pokemon> pokemons;

        public Person(string name)
        {
            this.Name = name;
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
            this.Pokemons = new List<Pokemon>();

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public Company Company
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }

        public Car Car
        {
            get
            {
                return this.car;
            }
            set
            {
                this.car = value;
            }
        }

        public List<Parent> Parents
        {
            get
            {
                return this.parents;
            }
            set
            {
                this.parents = value;
            }
        }

        public List<Child> Children
        {
            get
            {
                return this.children;
            }
            set
            {
                this.children = value;
            }
        }

        public List<Pokemon> Pokemons
        {
            get
            {
                return this.pokemons;
            }
            set
            {
                this.pokemons = value;
            }
        }

        public void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine("Company:");
            if (this.company != null)
            {
                Console.WriteLine($"{this.company.Name} {this.company.Department} {this.company.Salary:f2}");
            }
            Console.WriteLine("Car:");
            if (this.car != null)
            {
                Console.WriteLine($"{this.car.Model} {this.car.Speed}");
            }


            Console.WriteLine("Pokemon:");
            if (this.pokemons.Count > 0)
            {
                foreach (var pokemon in this.pokemons)
                {
                    Console.WriteLine($"{pokemon.Name} {pokemon.Type}");
                }
            }

            Console.WriteLine("Parents:");
            if (this.parents.Count > 0)
            {
                foreach (var parent in this.parents)
                {
                    Console.WriteLine($"{parent.Name} {parent.Birthday}");
                }
            }

            Console.WriteLine("Children:");
            if (this.children.Count > 0)
            {
                foreach (var child in this.children)
                {
                    Console.WriteLine($"{child.Name} {child.Birthday}");
                }
            }


        }
    }
}
