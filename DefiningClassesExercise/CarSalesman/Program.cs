using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> enginesList = new List<Engine>();
            List<Car> carsList = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var collection = Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries);

                string model = collection[0];
                int power = int.Parse(collection[1]);
                string efficiency = string.Empty;
                string displacement = string.Empty;

                if (collection.Length == 2)
                {
                    displacement = "n/a";
                    efficiency = "n/a";
                }
                else if (collection.Length == 3)
                {
                    var check = collection[2].ToCharArray();
                    Match reg = Regex.Match(check[0].ToString(), @"[0-9]");
                    if (reg.Success)
                    {
                        displacement = collection[2];
                        efficiency = "n/a";
                    }
                    else
                    {
                        displacement = "n/a";
                        efficiency = collection[2];
                    }
                }
                else
                {
                    displacement = collection[2];
                    efficiency = collection[3];
                }

                Engine engine = new Engine(model, power, displacement, efficiency);
                enginesList.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var collection = Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries);


                string model = collection[0];
                Engine engine = enginesList.Where(e => e.Model == collection[1]).First();

                string weight = string.Empty;
                string color = string.Empty;

                if (collection.Length == 2)
                {
                    weight = "n/a";
                    color = "n/a";
                }
                else if (collection.Length == 3)
                {
                    var check = collection[2].ToCharArray();
                    Match reg = Regex.Match(check[0].ToString(), @"[0-9]");
                    if (reg.Success)
                    {
                        weight = collection[2];
                        color = "n/a";
                    }
                    else
                    {
                        weight = "n/a";
                        color = collection[2];
                    }
                }
                else
                {
                    weight = collection[2];
                    color = collection[3];
                }

                Car car = new Car(model, engine, weight, color);
                carsList.Add(car);
            }

            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Colour}");

            }
        }
    }
}
