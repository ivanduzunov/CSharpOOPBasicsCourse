using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double consumption)
            : base(fuelQuantity, consumption)
        {

        }

        public override double ConsumptionPerKm => base.ConsumptionPerKm + 1.6;

        public override void Refill(double fuel)
        {
            this.FuelQuantity += fuel * 0.95;
        }
    }
}
