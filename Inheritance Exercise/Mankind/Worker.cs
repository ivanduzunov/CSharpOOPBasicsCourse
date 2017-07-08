using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public override string LastName
        {
            get
            {
                return base.LastName;
            }
            set
            {
                if (IsStartingWithCapitalLetter(value) == false)
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                else if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }
               base.LastName = value;
            }
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }
        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal SalaryPerHour()
        {
            return (weekSalary / 5) / workHoursPerDay;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("First Name: ").AppendLine(this.FirstName)
                .Append("Last Name: ").AppendLine(this.LastName)
                .Append("Week Salary: ").AppendLine($"{this.WeekSalary:f2}")
                .Append("Hours per day: ").AppendLine($"{this.WorkHoursPerDay:f2}")
                .Append("Salary per hour: ").AppendLine($"{this.SalaryPerHour():f2}");

            return sb.ToString();
        }
    }
}
