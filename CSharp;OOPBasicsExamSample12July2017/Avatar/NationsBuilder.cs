using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


public class NationsBuilder
{
    private Nation airNation;
    private Nation waterNation;
    private Nation fireNation;
    private Nation earthNation;
    private List<Monument> Airmonuments;
    private List<Monument> Watermonuments;
    private List<Monument> Firemonuments;
    private List<Monument> Earthmonuments;
    private List<string> wars;

    public NationsBuilder()
    {
        this.airNation = new Nation();
        this.waterNation = new Nation();
        this.fireNation = new Nation();
        this.earthNation = new Nation();
        this.Airmonuments = new List<Monument>();
        this.Watermonuments = new List<Monument>();
        this.Firemonuments = new List<Monument>();
        this.Earthmonuments = new List<Monument>();
        this.wars = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        switch (benderArgs[1])
        {
            case "Air":
                Bender airBender = new AirBender(benderArgs[2], int.Parse(benderArgs[3]), double.Parse(benderArgs[4]));
                airNation.Benders.Add(airBender);
                break;

            case "Water":
                Bender waterBender = new WaterBender(benderArgs[2], int.Parse(benderArgs[3]), double.Parse(benderArgs[4]));
                waterNation.Benders.Add(waterBender);
                break;

            case "Fire":
                Bender fireBender = new FireBender(benderArgs[2], int.Parse(benderArgs[3]), double.Parse(benderArgs[4]));
                fireNation.Benders.Add(fireBender);
                break;

            case "Earth":
                Bender earthBender = new EarthBender(benderArgs[2], int.Parse(benderArgs[3]), double.Parse(benderArgs[4]));
                earthNation.Benders.Add(earthBender);
                break;
        }
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        switch (monumentArgs[1])
        {
            case "Air":
                Monument airMonument = new AirMonument(monumentArgs[2], int.Parse(monumentArgs[3]));
                Airmonuments.Add(airMonument);
                break;

            case "Water":
                Monument waterMonument = new WaterMonument(monumentArgs[2], int.Parse(monumentArgs[3]));
                Watermonuments.Add(waterMonument);
                break;

            case "Fire":
                Monument fireMonument = new FireMonument(monumentArgs[2], int.Parse(monumentArgs[3]));
                Firemonuments.Add(fireMonument);
                break;

            case "Earth":
                Monument earthMonument = new EarthMonument(monumentArgs[2], int.Parse(monumentArgs[3]));
                Earthmonuments.Add(earthMonument);
                break;
        }
    }
    public string GetStatus(string nationsType)
    {
        string bendersResult = $"{nationsType} Nation" + Environment.NewLine + "Benders:";
        string monumentsResult = "Monuments:";

        if (nationsType == "Air")
        {
            if (airNation.Benders.Count == 0)
            {
                bendersResult += " None";
            }
            else
            {
                foreach (var bender in airNation.Benders)
                {
                    bendersResult += Environment.NewLine + bender.ToString();
                }
            }
            if (Airmonuments.Count == 0)
            {
                monumentsResult += " None";
            }
            else
            {
                foreach (var monument in Airmonuments)
                {
                    monumentsResult += Environment.NewLine + monument.ToString();
                }
            }
        }
        else if (nationsType == "Fire")
        {
            if (fireNation.Benders.Count == 0)
            {
                bendersResult += " None";
            }
            else
            {
                foreach (var bender in fireNation.Benders)
                {
                    bendersResult += Environment.NewLine + bender.ToString();
                }
            }
            if (Firemonuments.Count == 0)
            {
                monumentsResult += " None";
            }
            else
            {
                foreach (var monument in Firemonuments)
                {
                    monumentsResult += Environment.NewLine + monument.ToString();
                }
            }
        }
        else if (nationsType == "Water")
        {
            if (waterNation.Benders.Count == 0)
            {
                bendersResult += " None";
            }
            else
            {
                foreach (var bender in waterNation.Benders)
                {
                    bendersResult += Environment.NewLine + bender.ToString();
                }
            }
            if (Watermonuments.Count == 0)
            {
                monumentsResult += " None";
            }
            else
            {
                foreach (var monument in Watermonuments)
                {
                    monumentsResult += Environment.NewLine + monument.ToString();
                }
            }
        }
        else if(nationsType == "Earth")
        {
            if (earthNation.Benders.Count == 0)
            {
                bendersResult += " None";
            }
            else
            {
                foreach (var bender in earthNation.Benders)
                {
                    bendersResult += Environment.NewLine + bender.ToString();
                }
            }
            if (Earthmonuments.Count == 0)
            {
                monumentsResult += " None";
            }
            else
            {
                foreach (var monument in Earthmonuments)
                {
                    monumentsResult += Environment.NewLine + monument.ToString();
                }
            }
        }

        return bendersResult + Environment.NewLine  + monumentsResult;
    }
    public void IssueWar(string nationsType)
    {
        wars.Add(nationsType);

        double airResult = (airNation.Benders.Select(b => b.Result).Sum() / 100) * (Airmonuments.Select(m => m.Result).Sum())
                             + airNation.Benders.Select(b => b.Result).Sum();

        double waterResult = (waterNation.Benders.Select(b => b.Result).Sum() / 100) * (Watermonuments.Select(m => m.Result).Sum())
                             + waterNation.Benders.Select(b => b.Result).Sum();

        double fireResult = (fireNation.Benders.Select(b => b.Result).Sum() / 100) * (Firemonuments.Select(m => m.Result).Sum())
                            + fireNation.Benders.Select(b => b.Result).Sum();


        double earthResult = (earthNation.Benders.Select(b => b.Result).Sum() / 100) * (Earthmonuments.Select(m => m.Result).Sum())
                             + earthNation.Benders.Select(b => b.Result).Sum();

        double maxNum = Math.Max(Math.Max(Math.Max(airResult, waterResult), fireResult), earthResult);

        if (maxNum == airResult)
        {
            waterNation.Benders = new List<Bender>();
            Watermonuments = new List<Monument>();
            fireNation.Benders = new List<Bender>();
            Firemonuments = new List<Monument>();
            earthNation.Benders = new List<Bender>();
            Earthmonuments = new List<Monument>();
        }
        else if (maxNum == waterResult)
        {
            airNation.Benders = new List<Bender>();
            Airmonuments = new List<Monument>();
            fireNation.Benders = new List<Bender>();
            Firemonuments = new List<Monument>();
            earthNation.Benders = new List<Bender>();
            Earthmonuments = new List<Monument>();
        }
        else if (maxNum == fireResult)
        {
            airNation.Benders = new List<Bender>();
            Airmonuments = new List<Monument>();
            earthNation.Benders = new List<Bender>();
            Earthmonuments = new List<Monument>();
            waterNation.Benders = new List<Bender>();
            Watermonuments = new List<Monument>();
        }
        else
        {
            airNation.Benders = new List<Bender>();
            Airmonuments = new List<Monument>();
            waterNation.Benders = new List<Bender>();
            Watermonuments = new List<Monument>();
            fireNation.Benders = new List<Bender>();
            Firemonuments = new List<Monument>();
        }

    }
    public string GetWarsRecord()
    {
        var result = "";
        int counter = 1;
        for (int i = 0; i < wars.Count - 1; i++)
        {

            result += $"War {counter} issued by {wars[i]}" + Environment.NewLine;
            counter++;
        }
        result += $"War {counter} issued by {wars[wars.Count - 1]}";

        return result;
    }
}






