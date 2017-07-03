using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Program
    {
        // 90/100
        public static void Main(string[] args)
        {
            List<Trainer> trainersList = new List<Trainer>();
            var input = "";
            while ((input = Console.ReadLine()) != "Tournament")
            {
                var tokens = input.Split();
                var trainerName = tokens[0];
                var pokemonName = tokens[1];
                var pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                if (!trainersList.Any(t => t.Name == trainerName))
                {
                    trainersList.Add(new Trainer(trainerName, 0));
                }
                trainersList.Where(t => t.Name == trainerName).First()
                    .Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
            }
            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainersList)
                {
                    if (trainer.Pokemons.Where(p => p.Element == input).Count() > 0)
                    {
                        trainer.Badges += 1;
                    }
                    else
                    {
                        int x = trainer.Pokemons.Count;
                        for (int i = 0; i < x; i++)
                        {
                            trainer.Pokemons[i].Health -= 10;
                        }
                    }
                }
            }

            foreach (var trainer in trainersList.OrderByDescending(t => t.Badges))
            {
                trainer.Print();
            }
        }
    }
}
