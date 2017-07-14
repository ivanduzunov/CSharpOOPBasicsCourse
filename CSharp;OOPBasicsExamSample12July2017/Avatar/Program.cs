using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        NationsBuilder nb = new NationsBuilder();

        var input = "";

        while ((input = Console.ReadLine().Trim()) != "Quit")
        {
            var inputArgs = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            switch (inputArgs[0])
            {
                case "Bender":
                    nb.AssignBender(inputArgs);
                    break;

                case "Monument":
                    nb.AssignMonument(inputArgs);
                    break;

                case "Status":
                    Console.WriteLine(nb.GetStatus(inputArgs[1]));
                    break;

                case "War":
                    nb.IssueWar(inputArgs[1]);
                    break;
            }
          
        }
        Console.WriteLine(nb.GetWarsRecord());
    }
}

