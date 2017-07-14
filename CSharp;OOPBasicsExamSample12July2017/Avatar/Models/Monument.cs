using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Monument
{
    private string name;
    private int result;

    public virtual int Result
    {
        get { return result; }
        set { result = value; }
    }


    public Monument(string name)
    {
        this.Name = name;
        this.Result = 0;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public override string ToString()
    {
        return $"Monument: {this.name}, ";
    }
    
}

