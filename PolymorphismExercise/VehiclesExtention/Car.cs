using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double consumption, double tankCapacity)
            : base(fuelQuantity, consumption, tankCapacity)
        {

        }

        public override double ConsumptionPerKm
        {
            get
            {
                return base.ConsumptionPerKm + 0.9;
            }
        }
        public override void Refill(double fuel)
        {
            if (fuel + FuelQuantity > TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            else if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += fuel;
        }
    }
}
