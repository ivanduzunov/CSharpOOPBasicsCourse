using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) :
            base(name, age)
        {

        }

        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
                base.Age = value;
            }
        }
        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}".ToString();
        }

    }
}
