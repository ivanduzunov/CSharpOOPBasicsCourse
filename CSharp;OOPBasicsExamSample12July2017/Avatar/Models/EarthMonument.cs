using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class EarthMonument : Monument
{
    private int earthAffinity;
    private int result;

    public EarthMonument(string name, int earthAffinity)
        : base(name)
    {
        this.EarthAffinity = earthAffinity;
        this.result = earthAffinity;
    }

    public int EarthAffinity
    {
        get { return earthAffinity; }
        set { earthAffinity = value; }
    }
    public override string ToString()
    {
        return "###Earth " + base.ToString() + $"Earth Affinity: {this.EarthAffinity}";
    }

    public override int Result => this.result;
}

