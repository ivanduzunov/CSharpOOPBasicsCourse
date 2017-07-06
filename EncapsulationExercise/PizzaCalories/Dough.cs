using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Dough
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;

        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        private string FlourType
        {
            set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }

        private string BakingTechnique
        {
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        private int Weight
        {
            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double Modifier()
        {
            double flourModifier;
            double bakingModifier;

            switch (this.flourType.ToLower())
            {
                case "white":
                    flourModifier = 1.5;
                    break;

                default:
                    flourModifier = 1;
                    break;
            }

            switch (this.bakingTechnique.ToLower())
            {
                case "crispy":
                    bakingModifier = 0.9;
                    break;

                case "chewy":
                    bakingModifier = 1.1;
                    break;

                default:
                    bakingModifier = 1;
                    break;
            }

            return 2 * this.weight * flourModifier * bakingModifier;
        }

    }
}
