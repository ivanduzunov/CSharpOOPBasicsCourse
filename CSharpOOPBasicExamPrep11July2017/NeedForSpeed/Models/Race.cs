using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Race
{
    private int length;
    private string route;
    private int prizePool;

    public Race(int length, string route, int prizePool)
    {
        this.Length = length;
        this.Route = route;
        this.PrizePool = prizePool;
        this.Participants = new Dictionary<int, Car>();
    }


    public int Length
    {
        get { return this.length; }
        set { this.length = value; }
    }
    public string Route
    {
        get { return this.route; }
        set { this.route = value; }
    }
    public int PrizePool
    {
        get { return this.prizePool; }
        set { this.prizePool = value; }
    }
    public Dictionary<int, Car> Participants { get; set; }

}

