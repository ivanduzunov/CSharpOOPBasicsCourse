using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.Stars = 0;
    }

    public int Stars
    {
        get { return this.stars; }
        set { this.stars = value; }
    }
    public override void TuneUp(int tuneIndex, string addOn)
    {
        base.TuneUp(tuneIndex, addOn);
        this.stars += tuneIndex;
    }
    public override string ToString()
    {
        return base.ToString() + $"{this.Stars} *";
    }
}

