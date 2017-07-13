using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AirBender : Bender
{
    private double aerialIntegrity;

    public AirBender(string name, int power, double aerialIntegrity)
        : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public double AerialIntegrity
    {
        get { return aerialIntegrity; }
        set { aerialIntegrity = value; }
    }
}

