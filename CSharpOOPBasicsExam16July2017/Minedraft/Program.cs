using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {

        DraftManager dm = new DraftManager();
        var input = string.Empty;

        while ((input = Console.ReadLine()) != "Shutdown")
        {
            var inputArgs = input.Split(' ').ToList();

            switch (inputArgs[0])
            {
                case "RegisterHarvester":
                    Console.WriteLine(dm.RegisterHarvester(inputArgs));

                    break;
                case "RegisterProvider":
                    Console.WriteLine(dm.RegisterProvider(inputArgs));
                    break;

                case "Day":
                    Console.WriteLine(dm.Day());
                    break;

                case "Check":
                    Console.WriteLine(dm.Check(inputArgs));
                    break;

                case "Mode":
                    Console.WriteLine(dm.Mode(inputArgs));
                    break;
            }
        }

        Console.WriteLine(dm.ShutDown());
    }
}

