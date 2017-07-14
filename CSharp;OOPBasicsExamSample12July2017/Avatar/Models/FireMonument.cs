using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FireMonument : Monument
{
    private int fireAffinity;
    private int result;

    public FireMonument(string name, int fireAffinity)
        : base(name)
    {
        this.FireAffinity = fireAffinity;
        this.result = fireAffinity;
    }

    public int FireAffinity
    {
        get { return fireAffinity; }
        set { fireAffinity = value; }
    }
    public override string ToString()
    {
        return "###Fire " + base.ToString() + $"Fire Affinity: {this.FireAffinity}";
    }

    public override int Result => this.result;
}

