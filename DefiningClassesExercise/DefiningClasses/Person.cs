using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public Person()
        {
            this.age = 1;
            this.name = "No name";
        }
        public Person(int age)
        {
            this.age = age;
            this.name = "No name";
        }
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public string name;
        public int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
    }
}
