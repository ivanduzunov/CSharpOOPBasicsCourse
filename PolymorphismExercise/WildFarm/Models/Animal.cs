using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        public Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            this.AnimalName = animalName;
            this.AnimalType = animalType;
            this.animalWeight = animalWeight;
            this.FoodEaten = foodEaten;
        }

        public string AnimalName
        {
            get { return this.animalName; }
            set { this.animalName = value; }
        }
        public string AnimalType
        {
            get { return animalType; }
            set { animalType = value; }
        }
        public double AnimalWeight
        {
            get { return this.animalWeight; }
            set { this.animalWeight = value; }
        }
        public int FoodEaten
        {
            get { return this.foodEaten; }
            set { this.foodEaten = value; }
        }

        public virtual void makeSound() { }
        public virtual void Eat(Food food) { }

    }
}
