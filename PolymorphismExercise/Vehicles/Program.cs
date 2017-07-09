using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var carInput = Console.ReadLine().Split();
            var truckInput = Console.ReadLine().Split();

            Vehicle car = new Car(decimal.Parse(carInput[1]), decimal.Parse(carInput[2]));
            Vehicle truck = new Truck(decimal.Parse(truckInput[1]), decimal.Parse(truckInput[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Drive")
                {
                    switch (command[1])
                    {
                        case "Car":
                            var neededFuel = decimal.Parse(command[2]) * car.ConsumptionPerKm;

                            if (neededFuel > car.FuelQuantity)
                            {
                                Console.WriteLine($"Car needs refueling");
                            }
                            else
                            {
                                Console.WriteLine($"Car travelled {command[2]} km");
                                car.PullOutFuel(neededFuel);
                            }
                            break;

                        case "Truck":
                            var needed = decimal.Parse(command[2]) * truck.ConsumptionPerKm;

                            if (needed > truck.FuelQuantity)
                            {
                                Console.WriteLine($"Truck needs refueling");
                            }
                            else
                            {
                                Console.WriteLine($"Truck travelled {command[2]} km");
                                truck.PullOutFuel(needed);
                            }
                            break;
                    }
                }
                else
                {
                    switch (command[1])
                    {
                        case "Car":
                            car.Refill(decimal.Parse(command[2]));
                            break;

                        case "Truck":
                            truck.Refill(decimal.Parse(command[2]));
                            break;
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
