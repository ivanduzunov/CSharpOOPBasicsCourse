using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(decimal fuelQuantity, decimal consumption, decimal tankCapacity)
            : base(fuelQuantity, consumption, tankCapacity)
        {
            
        }

        public override decimal ConsumptionPerKm
        {
            get
            {
                return base.ConsumptionPerKm + (decimal)0.9;
            }          
        }
        public override void Refill(decimal fuel)
        {
            this.FuelQuantity += fuel;
        }
    }
}
