using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Bender
{
    private string name;
    private int power;
    private double result;

    public virtual double Result
    {
        get { return result; }
        set { result = value; }
    }


    public Bender(string name, int power)
    {
        this.Name = name;
        this.Power = power;
        this.Result = power;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Power
    {
        get { return power; }
        set { power = value; }
    }

    public override string ToString()
    {
        return $"Bender: {this.Name}, Power: {this.Power}, ";
    }

}



