using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double consumption)
            : base(fuelQuantity, consumption)
        {

        }

        public override double ConsumptionPerKm => base.ConsumptionPerKm + 0.9;

        public override void Refill(double fuel)
        {
            this.FuelQuantity += fuel;
        }
    }
}
