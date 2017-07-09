using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(decimal fuelQuantity, decimal consumption)
            : base(fuelQuantity, consumption)
        {
            
        }

        public override decimal ConsumptionPerKm
        {
            get
            {
                return base.ConsumptionPerKm;
            }
            set
            {
                var value1 = base.ConsumptionPerKm + (decimal)1.6;
                value1 = value;
            }
        }
        public override void Refill(decimal fuel)
        {
            this.FuelQuantity += fuel * 0.95m;
        }
    }
}
