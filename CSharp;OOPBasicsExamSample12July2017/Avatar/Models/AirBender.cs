using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AirBender : Bender
{
    private double aerialIntegrity;
    private double result;

    public AirBender(string name, int power, double aerialIntegrity)
        : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
        this.result = base.Result * this.aerialIntegrity;
    }

    public double AerialIntegrity
    {
        get { return aerialIntegrity; }
        set { aerialIntegrity = value; }
    }

    public override string ToString()
    {
        return $"###Air " + base.ToString() + $"Aerial Integrity: {this.aerialIntegrity:f2}";
    }

    public override double Result => result;
}

