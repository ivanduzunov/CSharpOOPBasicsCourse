﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(decimal fuelQuantity, decimal consumption)
            : base(fuelQuantity, consumption)
        {
            
        }

        public override decimal ConsumptionPerKm => base.ConsumptionPerKm + (decimal)0.9;

        public override void Refill(decimal fuel)
        {
            this.FuelQuantity += fuel;
        }
    }
}
