using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public class Cat : Felime
    {
        private string breed;

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion, string breed)
            : base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public override void makeSound()
        {
            Console.WriteLine("Meowwww");
        }
        public override void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
        }
        public override string ToString()
        {
            var toReturn = $"{AnimalType}[{AnimalName}, {Breed}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
            return toReturn;
        }
    }
}
