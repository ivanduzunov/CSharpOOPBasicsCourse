using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Vehicles;

namespace VehiclesExtention
{
    public class Bus : Vehicle
    {
        private bool busIsEmpty;

        public Bus(double fuelQuantity, double consumption, double tankCapacity, bool isEmpty)
            : base(fuelQuantity, consumption, tankCapacity)
        {
            this.BusIsEmpty = isEmpty;
        }

        public override double ConsumptionPerKm
        {
            get
            {
                if (BusIsEmpty == true)
                {
                    return base.ConsumptionPerKm;
                }
                else
                {
                    return base.ConsumptionPerKm + 1.4;
                }
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

        public bool BusIsEmpty
        {
            get { return this.busIsEmpty; }
            set { this.busIsEmpty = value; }
        }
    }
}
