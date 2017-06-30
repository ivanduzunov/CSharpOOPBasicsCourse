using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public class DateModifier
    {
        private string firstDate;
        private string secondtDate;

        public string FirstDate
        {
            get
            {
                return this.firstDate;
            }
            set
            {
                this.firstDate = value;
            }
        }

        public string SecondDate
        {
            get
            {
                return this.secondtDate;
            }
            set
            {
                this.secondtDate = value;
            }
        }

        public double CalculateDifference()
        {
            var dateOne = DateTime.Parse(this.firstDate);
            var dateTwo = DateTime.Parse(this.secondtDate);

            var answer = (dateOne - dateTwo).TotalDays;
            return Math.Abs(answer);
        }

    }
}
