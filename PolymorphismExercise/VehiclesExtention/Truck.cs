using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double consumption, double tankCapacity)
            : base(fuelQuantity, consumption, tankCapacity)
        {

        }

        public override double ConsumptionPerKm
        {
            get
            {
                return base.ConsumptionPerKm + 1.6;
            }

        }
        public override void Refill(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += fuel * 0.95;
        }
    }
}
