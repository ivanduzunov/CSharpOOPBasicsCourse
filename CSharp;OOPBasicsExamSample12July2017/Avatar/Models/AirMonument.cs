using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AirMonument : Monument
{
    private int airAffinity;
    private int result;

    public AirMonument(string name, int airAffinity)
        : base(name)
    {
        this.AirAffinity = airAffinity;
        this.result = airAffinity;
    }

    public int AirAffinity
    {
        get { return airAffinity; }
        set { airAffinity = value; }
    }

    public override string ToString()
    {
        return "###Air " + base.ToString() + $"Air Affinity: {this.AirAffinity}";
    }

    public override int Result => this.result;
}

