using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {

                if (IsStartingWithCapitalLetter(value) == false)
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }
                else if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 4 symbols!Argument: firstName");
                }
                this.firstName = value;
            }
        }
        public virtual string LastName
        {
            get { return this.lastName; }
            set
            {
                if (IsStartingWithCapitalLetter(value) == false)
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }
                else if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols!Argument: lastName");
                }
                this.lastName = value;
            }
        }

        public bool IsStartingWithCapitalLetter(string name)
        {
            var check = name.ToCharArray();
            if (name[0].ToString() == name[0].ToString().ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
