using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oldest_Family_Member
{
    public class Family
    {
        public Family()
        {
            this.members = new List<Person>();
        }
        public List<Person> members { get; set; }
        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public void GetOldestMember()
        {
            var result = members.OrderByDescending(p => p.age).First();
            Console.WriteLine($"{result.name} {result.age}");
        }
    }
}
