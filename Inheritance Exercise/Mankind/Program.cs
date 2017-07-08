using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var studentInput = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var workerInput = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                Student student = new Student(studentInput[0], studentInput[1], studentInput[2]);
                Worker worker = new Worker(workerInput[0], workerInput[1], decimal.Parse(workerInput[2]), decimal.Parse(workerInput[3]));
                Console.WriteLine(student.ToString());
                Console.WriteLine(worker.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
