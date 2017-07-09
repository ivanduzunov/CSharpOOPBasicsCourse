using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Vehicle
    {
        private decimal fuelQuantity;
        private decimal consumptionPerKm;

        public Vehicle(decimal fuelQuantity, decimal consumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.consumptionPerKm = consumption;
        }

        public  decimal FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public virtual decimal ConsumptionPerKm
        {
            get { return consumptionPerKm; }
            set { consumptionPerKm = value; }
        }

        public virtual void Refill(decimal fuel)
        {
            
        }

        public  void PullOutFuel(decimal fuel)
        {
            this.FuelQuantity -= fuel;
        }
    }
}
