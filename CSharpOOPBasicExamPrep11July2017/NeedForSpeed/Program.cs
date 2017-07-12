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
            }

        }
        

    }

}

