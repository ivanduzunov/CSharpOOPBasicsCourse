using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Vehicle
    {
        private double fuelQuantity;
        private double consumptionPerKm;

        public Vehicle(double fuelQuantity, double consumption)
        {
            this.FuelQuantity = fuelQuantity;
            this.consumptionPerKm = consumption;
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public virtual double ConsumptionPerKm
        {
            get { return consumptionPerKm; }
            set { consumptionPerKm = value; }
        }

        public virtual void Refill(double fuel)
        {
            
        }

        public  void PullOutFuel(double fuel)
        {
            this.FuelQuantity -= fuel;
        }
    }
}
