using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            try
            {
                Box box = new Box(lenght, width, height);
                Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {box.Volume():f2}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
