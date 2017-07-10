using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm.Models
{
    public abstract class Food
    {
        private int quantity;

        public Food(int quantty)
        {
            this.Quantity = quantty;
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }

    }
}
