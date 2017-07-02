using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                var cargoType = input[4];
                List<Tire> tires = new List<Tire>();

                for (int j = 5; j < 13; j += 2)
                {
                    Tire tire = new Tire(double.Parse(input[j]), int.Parse(input[j + 1]));
                    tires.Add(tire);
                }

                Car car = new Car(model, new Engine(engineSpeed, enginePower)
                    , new Cargo(cargoWeight, cargoType), tires);
                cars.Add(car);
            }

            var resultType = Console.ReadLine();
            var result = new List<Car>();
            List<Car> resultPrint = new List<Car>();
            if (resultType == "fragile")
            {
                result = cars.Where(c => c.Cargo.Type == "fragile").ToList();
                int x = result.Count;  
               
                for (int i = 0; i < x; i++)
                {
                    List<Tire> check = result[i].Tires.ToList();
                    int counter = 0;
                    foreach (var tire in check)
                    {
                                        
                        if (tire.Pressure < 1)
                        {
                            counter++;
                        }
                    }
                                    
                    if (counter > 0)
                    {
                        resultPrint.Add(result[i]);
                    }
                }
            }
            else
            {
                resultPrint = cars.Where(c => c.Cargo.Type == "flamable").Where(c => c.Engine.Power > 250).ToList();               
            }

            foreach (var car in resultPrint)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
