using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            var peopleInput = Console.ReadLine().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i < peopleInput.Length; i++)
            {
                var peopleInputSplitted = peopleInput[i].Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                var name = peopleInputSplitted[0];
                decimal money = decimal.Parse(peopleInputSplitted[1]);

                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            var productsInput = Console.ReadLine().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < productsInput.Length; i++)
            {
                var productInputSplitted = productsInput[i].Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                var name = productInputSplitted[0];
                decimal cost = decimal.Parse(productInputSplitted[1]);

                try
                {
                    Product product = new Product(name, cost);
                    products.Add(product);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            var purchase = "";
            while ((purchase = Console.ReadLine()) != "END")
            {
                var elements = purchase.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    var person = people.Where(p => p.Name.Equals(elements[0])).First();
                    var product = products.Where(p => p.Name.Equals(elements[1])).First();

                    if (person.Money >= product.Cost)
                    {
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                        people.Where(p => p.Name.Equals(elements[0])).First().Money -= product.Cost;
                        people.Where(p => p.Name.Equals(elements[0])).First().BagOfProducts.Add(product);
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} can't afford {product.Name}");
                    }
                }
                catch (Exception e)
                {
                    
                }


            }
            foreach (var person in people)
            {
                if (person.BagOfProducts.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts.Select(p => p.Name))}");

                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}
