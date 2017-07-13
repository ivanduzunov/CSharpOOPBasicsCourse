using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Nation
{
    private List<Bender> benders;

    public Nation()
    {
        this.Benders = new List<Bender>();
    }

    public List<Bender> Benders
    {
        get { return benders; }
        set { benders = value; }
    }
}

