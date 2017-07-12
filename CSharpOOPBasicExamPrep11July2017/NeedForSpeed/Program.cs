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
       
        string expectedOutputTest2 = "Dragon - 1000\r\n" + "1. BMW M3 235PP - $50";


        

        CarManager manager = new CarManager();
        manager.Register(1, "Performance", "BMW", "M3", 1992, 200, 5, 100, 100);
        Console.WriteLine(manager.Check(1));
        Console.WriteLine();      
        manager.Open(1, "Casual", 1000, "Dragon", 100);
        manager.Participate(1,1);
        var result = manager.Start(1);
        Console.WriteLine(result);
        Console.WriteLine();
        Console.WriteLine(expectedOutputTest2);
    }

}

