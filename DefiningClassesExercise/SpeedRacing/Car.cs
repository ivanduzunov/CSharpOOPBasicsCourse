using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private decimal fuelAmount;
        private decimal fuelConsumption;
        private decimal distanceTraveled;
        private int insufficient;
        public Car()
        {
        }

        public string Model { get { return this.model; } set { this.model = value; } }
        public decimal FuelAmount { get { return this.fuelAmount; } set { this.fuelAmount = value; } }
        public decimal FuelConsumption { get { return this.fuelConsumption; } set { this.fuelConsumption = value; } }
        public decimal DistanceTraveled { get { return this.distanceTraveled; } set { this.distanceTraveled = value; } }
        public int Insufficient { get { return this.insufficient; } set { this.insufficient = value; } }
        public void CanTravel(decimal amountOfKm)
        {
            if (this.fuelConsumption * amountOfKm <= this.fuelAmount)
            {
                fuelAmount -= fuelConsumption * amountOfKm;
                DistanceTraveled += amountOfKm;
            }
            else
            {
                insufficient += 1;
            }
        }
    }
}
