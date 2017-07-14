using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FireBender : Bender
{
    private double heatAggression;
    private double result;

    public FireBender(string name, int power, double heatAggression)
        : base(name, power)
    {
        this.HeatAggression = heatAggression;
        this.result = base.Result * this.heatAggression;
        
    }

    public double HeatAggression
    {
        get { return heatAggression; }
        set { heatAggression = value; }
    }
    public override string ToString()
    {
        return $"###Fire " + base.ToString() + $"Heat Aggression: {this.heatAggression:f2}";
    }

    public override double Result => result;
}

