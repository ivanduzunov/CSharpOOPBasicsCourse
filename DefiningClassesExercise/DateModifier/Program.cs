using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondtDate = Console.ReadLine();

            var dateSet = new DateModifier
            {
                FirstDate = firstDate,
                SecondDate = secondtDate
            };


            Console.WriteLine(dateSet.CalculateDifference());

           

        }
    }
}
