using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesExtention;

namespace Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var carInput = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var truckInput = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var busInput = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            Vehicle car = new Car(double.Parse(carInput[1]), double.Parse(carInput[2]), double.Parse(carInput[3]));
            Vehicle truck = new Truck(double.Parse(truckInput[1]), double.Parse(truckInput[2]), double.Parse(truckInput[3]));
            Bus bus = new Bus(double.Parse(busInput[1]), double.Parse(busInput[2]), double.Parse(busInput[3]), false);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Drive" || command[0] == "DriveEmpty")
                {
                    try
                    {
                        switch (command[1])
                        {
                            case "Car":
                                var neededFuel = double.Parse(command[2]) * car.ConsumptionPerKm;

                                if (neededFuel > car.FuelQuantity)
                                {
                                    Console.WriteLine($"Car needs refueling");
                                }
                                else
                                {
                                    Console.WriteLine($"Car travelled {double.Parse(command[2])} km");
                                    car.PullOutFuel(neededFuel);
                                }
                                break;

                            case "Truck":
                                var needed = double.Parse(command[2]) * truck.ConsumptionPerKm;

                                if (needed > truck.FuelQuantity)
                                {
                                    Console.WriteLine($"Truck needs refueling");
                                }
                                else
                                {
                                    Console.WriteLine($"Truck travelled {double.Parse(command[2])} km");
                                    truck.PullOutFuel(needed);
                                }
                                break;
                            case "Bus":
                                if (command[0] == "DriveEmpty")
                                {
                                    bus.BusIsEmpty = true;
                                }
                                else
                                {
                                    bus.BusIsEmpty = false;
                                }

                                var neededF = double.Parse(command[2]) * bus.ConsumptionPerKm;

                                if (neededF > bus.FuelQuantity)
                                {
                                    Console.WriteLine($"Bus needs refueling");
                                }
                                else
                                {
                                    Console.WriteLine($"Bus travelled {double.Parse(command[2])} km");
                                    bus.PullOutFuel(neededF);
                                }
                                break;

                        }
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    try
                    {
                        switch (command[1])
                        {
                            case "Car":
                                car.Refill(double.Parse(command[2]));
                                break;

                            case "Truck":
                                truck.Refill(double.Parse(command[2]));
                                break;

                            case "Bus":
                                bus.Refill(double.Parse(command[2]));
                                break;
                        }
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
