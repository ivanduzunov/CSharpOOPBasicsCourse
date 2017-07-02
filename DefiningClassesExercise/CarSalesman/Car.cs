using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine, string weight, string colour)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Colour = colour;
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Colour { get; set; }

    }
}
