using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class EarthBender : Bender
{
    private double groundSaturation;
    private double result;

    public EarthBender(string name, int power, double groundSaturation)
        : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
        this.result = base.Result * this.groundSaturation;
    }

    public double GroundSaturation
    {
        get { return groundSaturation; }
        set { groundSaturation = value; }
    }
    public override string ToString()
    {
        return $"###Earth " + base.ToString() + $"Ground Saturation: {this.groundSaturation:f2}";
    }

    public override double Result => result;
}

