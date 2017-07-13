using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;




public class Program
{

    public static void Main(string[] args)
    {

        CarManager manager = new CarManager();
        var input = "";

        while ((input = Console.ReadLine()) != "Cops Are Here")
        {
            var tokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            switch (tokens[0])
            {
                case "register":
                    int id = int.Parse(tokens[1]);
                    var carType = tokens[2];
                    string brand = tokens[3];
                    string model = tokens[4];
                    int yearOfProduction = int.Parse(tokens[5]);
                    int horsepower = int.Parse(tokens[6]);
                    int acceleration = int.Parse(tokens[7]);
                    int suspension = int.Parse(tokens[8]);
                    int durability = int.Parse(tokens[9]);
                    manager.Register(id, carType, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                    break;
                case "open":
                    int raceid = int.Parse(tokens[1]);
                    var raceType = tokens[2];
                    int length = int.Parse(tokens[3]);
                    var route = tokens[4];
                    int prizePool = int.Parse(tokens[5]);
                    manager.Open(raceid, raceType, length, route, prizePool);
                    break;
                case "check":
                    Console.WriteLine(manager.Check(int.Parse(tokens[1])));                    
                    break;
                case "participate":
                    manager.Participate(int.Parse(tokens[1]), int.Parse(tokens[2]));
                    break;
                case "start":
                    Console.WriteLine(manager.Start(int.Parse(tokens[1])));                                     
                    break;
                case "park":
                    manager.Park(int.Parse(tokens[1]));
                    break;
                case "unpark":
                    manager.Unpark(int.Parse(tokens[1]));
                    break;
                case "tune":
                    int index = int.Parse(tokens[1]);
                    var addOn = tokens[2];
                    manager.Tune(index,addOn);
                    break;
            }
        }
    }

}

