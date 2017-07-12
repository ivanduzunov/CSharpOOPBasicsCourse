using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.AddOns = new List<string>();
        this.Horsepower += (base.Horsepower * 50) / 100;
        this.Suspension -= (base.Suspension * 25) / 100;
    }

    
    public List<string> AddOns { get { return this.addOns; } set { this.addOns = value; } }
    public override void TuneUp(int tuneIndex, string addOn)
    {
        base.TuneUp(tuneIndex, addOn);
        this.addOns.Add(addOn);
    }
    public override string ToString()
    {
        var result = "";
        if (addOns.Count == 0)
        {
            result = base.ToString() + "Add-ons: None";
        }
        else
        {
            result = base.ToString() + $"Add-ons: {string.Join(", ", addOns)}";
        }
        return result;
    }
}

