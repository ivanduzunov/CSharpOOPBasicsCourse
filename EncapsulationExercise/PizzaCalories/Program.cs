using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var firstRow = Console.ReadLine().Split();
            if (firstRow[0].ToLower() == "pizza")
            {
                var pizzaTokens = firstRow;
                Pizza pizza;
                var doughTokens = Console.ReadLine().Split();
                List<string> toppingsList = new List<string>();
                var input = "";

                while ((input = Console.ReadLine()) != "END" || int.Parse(pizzaTokens[2]) == 0)
                {
                    toppingsList.Add(input);
                }

                try
                {
                    pizza = new Pizza(
                        pizzaTokens[1],
                        int.Parse(pizzaTokens[2]));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }


                try
                {
                    pizza.Dough = new Dough(doughTokens[1].ToLower(), doughTokens[2], int.Parse(doughTokens[3]));
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }


                List<Topping> toppings = new List<Topping>();


                for (int i = 0; i < pizza.NumberOfToppings; i++)
                {
                    var toppingTokens = toppingsList[i].Split();
                    try
                    {
                        Topping topping = new Topping(toppingTokens[1], int.Parse(toppingTokens[2]));
                        toppings.Add(topping);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }

                pizza.Toppings = toppings;

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories():f2} Calories.");
            }

            else
            {
                var tokens = firstRow;

                while (tokens[0] != "END")
                {
                    if (tokens[0] == "Dough")
                    {
                        try
                        {
                            Dough dough = new Dough(tokens[1].ToLower(), tokens[2], int.Parse(tokens[3]));
                            Console.WriteLine($"{dough.Modifier():f2}");
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                            return;
                        }
                    }
                    else if (tokens[0] == "Topping")
                    {
                        try
                        {
                            Topping topping = new Topping(tokens[1], int.Parse(tokens[2]));
                            Console.WriteLine($"{topping.Modifier():f2}");
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                            return;
                        }
                    }

                    tokens = Console.ReadLine().Split();
                }
            }
        }
    }
}
