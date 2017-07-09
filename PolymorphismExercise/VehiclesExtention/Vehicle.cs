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
        private decimal tankCapacity;

        public Vehicle(decimal fuelQuantity, decimal consumption, decimal tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.consumptionPerKm = consumption;
            this.TankCapacity = tankCapacity;
        }

        public decimal FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }       
        public virtual decimal ConsumptionPerKm
        {
            get { return consumptionPerKm; }
            set { consumptionPerKm = value; }
        }
        public decimal TankCapacity
        {
            get { return this.tankCapacity; }
            set { this.tankCapacity = value; }
        }

        public virtual void Refill(decimal fuel)
        {

        }

        public void PullOutFuel(decimal fuel)
        {
            this.FuelQuantity -= fuel;
        }
    }
}
