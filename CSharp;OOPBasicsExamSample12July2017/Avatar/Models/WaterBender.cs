using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WaterBender : Bender
{
    private double waterClarity;
    private double result;

    public WaterBender(string name, int power, double waterClarity)
    : base(name, power)
    {
        this.WaterClarity = waterClarity;
        this.result = base.Result * this.waterClarity;
    }

    public double WaterClarity
    {
        get { return waterClarity; }
        set { waterClarity = value; }
    }
    public override string ToString()
    {
        return $"###Water " + base.ToString() + $"Water Clarity: {this.waterClarity:f2}";
    }

    public override double Result => result;

}

