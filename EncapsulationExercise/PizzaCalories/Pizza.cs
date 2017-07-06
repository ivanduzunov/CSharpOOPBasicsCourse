using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private int numberfToppings;
        private List<Topping> toppings;

        public Pizza(string name, int numberOfToppings)
        {
            this.Name = name;
            this.NumberOfToppings = numberOfToppings;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.ToCharArray().Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }
        public int NumberOfToppings
        {
            get { return this.numberfToppings; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Number of toppings should be in range [0..10].");
                }
                this.numberfToppings = value;
            }
        }
        public Dough Dough
        {
            set
            {
                this.dough = value;
            }
        }
        public List<Topping> Toppings { get { return this.toppings; } set { this.toppings = value; } }
        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }
        public double TotalCalories()
        {
            return this.dough.Modifier() + this.toppings.Sum(t => t.Modifier());
        }
    }
}
