using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                var model = input[0];
                decimal fAmount = decimal.Parse(input[1]);
                decimal fConsumption = decimal.Parse(input[2]);

                Car car = new Car()
                {
                    Model = model,
                    FuelAmount = fAmount,
                    FuelConsumption = fConsumption,
                    DistanceTraveled = 0
                };
                var check = carsList.Where(c => c.Model == model).ToList();
                if (check.Count > 0)
                {
                    continue;
                }
                else
                {
                    carsList.Add(car);
                }
            }
            carsList.Distinct();
            var command = Console.ReadLine();
            while (command != "End")
            {
                var elements = command.Split();
                var carModel = elements[1];
                var amuntOfKm = decimal.Parse(elements[2]);
                carsList.Where(c => c.Model == carModel).First().CanTravel(amuntOfKm);
                command = Console.ReadLine();
            }
            foreach (var car in carsList)
            {
                for (int i = 0; i < car.Insufficient; i++)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
            foreach (var car in carsList)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
            }
        }
    }
}
