using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace VehiclesExtention
{
    public class Bus : Vehicle
    {
        public Bus(decimal fuelQuantity, decimal consumption, decimal tankCapacity)
            : base(fuelQuantity, consumption, tankCapacity)
        {

        }

        public override decimal ConsumptionPerKm
        {
            get
            {
                return base.ConsumptionPerKm + (decimal)1.6;
            }

        }
        public override void Refill(decimal fuel)
        {
            this.FuelQuantity += fuel * 0.95m;
        }
    }
}
