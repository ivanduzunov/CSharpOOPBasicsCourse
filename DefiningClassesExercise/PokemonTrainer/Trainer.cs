using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(string name, int badges)
        {
            this.Name = name;
            this.Badges = badges;
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
        public int Badges
        {
            get
            {
                return this.badges;
            }
            set
            {
                this.badges = value;
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
            Console.WriteLine($"{this.name} {this.badges} {this.pokemons.Where(p => p.Health > 0).Count()}");
        }
    }
}
