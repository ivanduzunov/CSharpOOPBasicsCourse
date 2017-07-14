using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class WaterMonument : Monument
{
    private int waterAffinity;
    private int result;

    public WaterMonument(string name, int waterAffinity)
        : base(name)
    {
        this.WaterAffinity = waterAffinity;
        this.result = waterAffinity;
    }

    public int WaterAffinity
    {
        get { return waterAffinity; }
        set { waterAffinity = value; }
    }
    public override string ToString()
    {
        return "###Water " + base.ToString() + $"Water Affinity: {this.WaterAffinity}";
    }

    public override int Result => this.result;
}

