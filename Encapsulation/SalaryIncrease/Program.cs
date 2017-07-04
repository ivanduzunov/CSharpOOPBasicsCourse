using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        Team team = new Team("Levski");


        for (int i = 0; i < lines; i++)
        {
            try
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    double.Parse(cmdArgs[3]));

                persons.Add(person);
                team.AddPlayer(person);
            }
            catch (Exception e)
            {
                Console.WriteLine(new ArgumentException(e.Message));
               
            }
            
        }

        //var percent = double.Parse(Console.ReadLine());
        //persons.ForEach(p => p.IncreaseSalary(percent));
        //persons.ForEach(p => Console.WriteLine(p.ToString()));
        Console.WriteLine($"First team have {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
    }
}

