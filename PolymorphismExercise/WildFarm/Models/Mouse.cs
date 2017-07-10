using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion)
            : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
        }

        public override void makeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }
        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat")
            {
                throw new ArgumentException("Mouses are not eating that type of food!");
            }
            this.FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            var toReturn = $"{AnimalType}[{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
            return toReturn;
        }
    }
}
