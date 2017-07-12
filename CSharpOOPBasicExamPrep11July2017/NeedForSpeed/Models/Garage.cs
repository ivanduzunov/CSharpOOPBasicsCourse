using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Garage
{
    public Garage()
    {
        this.ParkedCars = new Dictionary<int, Car>();
    }

    public Dictionary<int,Car> ParkedCars { get; set; }
}

