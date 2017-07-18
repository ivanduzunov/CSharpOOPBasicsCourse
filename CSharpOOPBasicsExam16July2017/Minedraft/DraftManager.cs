using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DraftManager
{
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private double totalProvidedEnergy;
    private double totalMinedOre;
    private string currentMode;

    public DraftManager()
    {
        this.Harvesters = new List<Harvester>();
        this.Providers = new List<Provider>();
        this.TotalProvidedEnergy = 0;
        this.totalMinedOre = 0;
        this.CurrentMode = "Full";
    }
    public List<Harvester> Harvesters
    {
        get { return this.harvesters; }
        set { this.harvesters = value; }
    }
    public List<Provider> Providers
    {
        get { return this.providers; }
        set { this.providers = value; }
    }
    public double TotalProvidedEnergy
    {
        get { return this.totalProvidedEnergy; }
        set { this.totalProvidedEnergy = value; }
    }
    public double TotalMinedOre
    {
        get { return this.totalMinedOre; }
        set { this.totalMinedOre = value; }
    }
    public string CurrentMode
    {
        get { return this.currentMode; }
        set { this.currentMode = value; }
    }




    public string RegisterHarvester(List<string> arguments)
    {
        var toReturn = string.Empty;
        try
        {
            if (arguments[0] == "Sonic")
            {

                Harvester harvester =
                    new SonicHarvester(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3]), int.Parse(arguments[4]));
                Harvesters.Add(harvester);
                toReturn = $"Successfully registered Sonic Harvester - {arguments[1]}";
            }
            else
            {
                Harvester harvester =
                    new HammerHarvester(arguments[1], double.Parse(arguments[2]), double.Parse(arguments[3]));
                Harvesters.Add(harvester);
                toReturn = $"Successfully registered Hammer Harvester - {arguments[1]}";
            }
        }
        catch (ArgumentException e)
        {
            toReturn = e.Message;
        }
        return toReturn;

    }
    public string RegisterProvider(List<string> arguments)
    {
        var toreturn = string.Empty;
        try
        {
            if (arguments[0] == "Solar")
            {
                Provider provider = new SolarProvider(arguments[1], double.Parse(arguments[2]));
                Providers.Add(provider);
                toreturn = $"Successfully registered Solar Provider - {arguments[1]}";
            }
            else
            {
                Provider provider = new PressureProvider(arguments[1], double.Parse(arguments[2]));
                Providers.Add(provider);
                toreturn = $"Successfully registered Pressure Provider - {arguments[1]}";
            }
        }
        catch (Exception e)
        {
            toreturn = e.Message;
        }
        return toreturn;
    }
    public string Day()
    {
        var toreturn = string.Empty;
        double requiredEnergy = 0;
        double oreMined = 0;
        double dayEnergy = providers.Select(p => p.EnergyOutput).Sum();
        TotalProvidedEnergy += dayEnergy;


        if (this.currentMode == "Full")
        {
            requiredEnergy = harvesters.Select(h => h.EnergyRequirement).Sum();

            if (requiredEnergy <= TotalProvidedEnergy)
            {
                oreMined = harvesters.Select(h => h.OreOutput).Sum();
                TotalProvidedEnergy -= requiredEnergy;
                TotalMinedOre += oreMined;
            }
        }
        else if (this.currentMode == "Half")
        {
            requiredEnergy = (harvesters.Select(h => h.EnergyRequirement).Sum() * 60) / 100;

            if (requiredEnergy <= TotalProvidedEnergy)
            {
                oreMined = (harvesters.Select(h => h.OreOutput).Sum() * 50) / 100;
                TotalProvidedEnergy -= requiredEnergy;
                TotalMinedOre += oreMined;
            }
        }
        var sb = new StringBuilder();
        sb.AppendLine($"A day has passed.");
        sb.AppendLine($"Energy Provided: {dayEnergy}");
        sb.AppendLine($"Plumbus Ore Mined: {oreMined}");
        return sb.ToString().Trim();
    }
    public string Mode(List<string> arguments)
    {
        var result = string.Empty;
        switch (arguments[0])
        {
            case "Half":
                currentMode = "Half";
                break;
            case "Energy":
                currentMode = "Energy";
                break;
            case "Full":
                currentMode = "Full";
                break;
        }
        return $"Successfully changed working mode to {this.currentMode} Mode"; ;
    }
    public string Check(List<string> arguments)
    {
        var toreturn = string.Empty;

        var provider = providers.Where(p => p.Id == arguments[0]).FirstOrDefault();
        var harvester = harvesters.Where(p => p.Id == arguments[0]).FirstOrDefault();

        if (provider != null)
        {
            toreturn = provider.ToString();
        }
        if (harvester != null)
        {
            toreturn = harvester.ToString();
        }
        if (toreturn != string.Empty)
        {
            return toreturn;
        }
        else
        {
            return $"No element found with id - {arguments[0]}";
        }
    }
    public string ShutDown()
    {
        var toreturn = new StringBuilder();

        toreturn.AppendLine("System Shutdown");
        toreturn.AppendLine($"Total Energy Stored: {TotalProvidedEnergy}");
        toreturn.AppendLine($"Total Mined Plumbus Ore: {totalMinedOre}");

        return toreturn.ToString().Trim();
        
    }

}
