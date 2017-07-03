using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google
{
    public class Company
    {
        private string name;
        private string department;
        private double salary;

        public Company(string name, string department, double salary)
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }

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

        public string Department
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }

        public double Salary
        {
            get
            {
                return this.salary;
            }
            set
            {
                this.salary = value;
            }
        }
    }
}
