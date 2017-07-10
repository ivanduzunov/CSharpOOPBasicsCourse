using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models;

namespace WildFarm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var animalInput = "";
            while ((animalInput = Console.ReadLine()) != "End")
            {
                var animalInputSplitted = animalInput.Split();
                Animal animal = CreateAnimal(animalInputSplitted);
                var foodInputSplitted = Console.ReadLine().Split();
                Food food = CreateFood(foodInputSplitted);
                animal.makeSound();
                Eating(animal, food);
                Console.WriteLine(animal.ToString());
            }
        }

        public static Animal CreateAnimal(string[] animalInputSplitted)
        {

            var animalType = animalInputSplitted[0];
            var animalName = animalInputSplitted[1];
            var animalWeight = double.Parse(animalInputSplitted[2]);
            var animalLivingRegion = animalInputSplitted[3];

            if (animalType == "Cat")
            {
                var catBreed = animalInputSplitted[4];
                Animal animal = new Cat(animalName, animalType, animalWeight, 0, animalLivingRegion, catBreed);
                return animal;
            }
            else if (animalType == "Tiger")
            {
                Animal animal = new Tiger(animalName, animalType, animalWeight, 0, animalLivingRegion);
                return animal;
            }
            else if (animalType == "Mouse")
            {
                Animal animal = new Mouse(animalName, animalType, animalWeight, 0, animalLivingRegion);
                return animal;
            }
            else
            {
                Animal animal = new Zebra(animalName, animalType, animalWeight, 0, animalLivingRegion);
                return animal;
            }

        }

        public static Food CreateFood(string[] foodInputSplitted)
        {
            var foodType = foodInputSplitted[0];
            int quantity = int.Parse(foodInputSplitted[1]);

            if (foodType == "Vegetable")
            {
                Food food = new Vegetable(quantity);
                return food;
            }
            else
            {
                Food food = new Meat(quantity);
                return food;
            }
        }

        public static void Eating(Animal animal, Food food)
        {
            try
            {
                animal.Eat(food);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
