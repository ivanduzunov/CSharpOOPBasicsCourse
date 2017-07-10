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
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double consumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.consumptionPerKm = consumption;
            this.tankCapacity = tankCapacity;
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                fuelQuantity = value;
            }
        }
        public virtual double ConsumptionPerKm
        {
            get { return consumptionPerKm; }
            set { consumptionPerKm = value; }
        }
        public virtual double TankCapacity
        {
            get { return this.tankCapacity; }
            set { this.tankCapacity = value; }
        }

        public virtual void Refill(double fuel)
        {

        }

        public void PullOutFuel(double fuel)
        {
            this.FuelQuantity -= fuel;
        }

    }
}
