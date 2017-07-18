using System;
using System.Collections.Generic;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Workers> workers;


    public DraftManager()
    {
        this.workers = new Dictionary<string, Workers>()
        {
            {"Sonic", new Workers()},
            {"Hammer", new Workers()}
        };
    }
    public string RegisterHarvester(List<string> arguments)
    {
        var harvesterType = arguments[0];
        var harvesterId = arguments[1];

        Harvester currentHarvester = this.GetHarvester(arguments);//SonicHarvester(harvesterId, harvesterOreOutput, harvesterEnergyRequirement, harvesterSonicFactor);
        this.workers[harvesterType].AddHarvester(currentHarvester);
        var sb = new StringBuilder();
        sb.Append($"Successfully registered {harvesterType} Harvester – {harvesterId}");
        return sb.ToString();
    }

    //{type} {id} {oreOutput} {energyRequirement}
    private Harvester GetHarvester(List<string> arguments)
    {
        var harvesterType = arguments[0];
        var harvesterId = arguments[1];
        var harvesterOreOutput = double.Parse(arguments[2]);
        var harvesterEnergyRequirement = double.Parse(arguments[3]);
        var harvesterSonicFactor = 0;
        if (arguments.Count.Equals(5))
        {
            harvesterSonicFactor = int.Parse(arguments[3]);
        }

        switch (harvesterType)
        {
            case "Sonic":
                return new SonicHarvester(harvesterId, harvesterOreOutput, harvesterEnergyRequirement, harvesterSonicFactor);
            case "Hammer":
                return new HammerHarvester(harvesterId, harvesterOreOutput, harvesterEnergyRequirement);
            default:
                throw new ArgumentException();
        }
    }
    public string RegisterProvider(List<string> arguments)
    {

        var providerType = arguments[0];
        var providerId = arguments[1];

        Provider currentProvider = this.GetPovider(arguments);//SonicHarvester(harvesterId, harvesterOreOutput, harvesterEnergyRequirement, harvesterSonicFactor);
        this.workers[providerType].AddProvider(currentProvider);
        var sb = new StringBuilder();
        sb.Append($"Successfully registered {providerType} Harvester – {providerId}");
        return sb.ToString();
    }

    private Provider GetPovider(List<string> arguments)
    {
        var providerType = arguments[0];
        var providerId = arguments[1];
        var providerenergyOutput = double.Parse(arguments[2]);
       

        switch (providerType)
        {
            case "Solar":
                return new PressureProvider(providerId, providerenergyOutput);
            case "Pressure":
                return new SolarProvider(providerId, providerenergyOutput);
            default:
                throw new ArgumentException();
        }
    }

    public string Day()
    {
        //TODO: Add some logic here …
        var arg = string.Empty;
        return arg;
    }
    public string Mode(List<string> arguments)
    {
        var modeType = arguments[0];
        switch (modeType)
        {
            case "Energy":
                return EnergyMode();
            case "Half ":
                return HalfMode();
            default:
                throw new ArgumentException();
        }
    }

    private string HalfMode()
    {
        var str = "Successfully changed working mode to Half Mode";
        return str;
    }

    private string EnergyMode()
    {
        var str = "Successfully changed working mode to Energy Mode";
        return str;
    }

    public string Check(List<string> arguments)
    {
        //TODO: Add some logic here …
        var arg = string.Empty;
        return arg;
    }
    public string ShutDown()
    {
        //TODO: Add some logic here …
        var arg = string.Empty;
        return arg;
    }

    public void totalStoredEnergy()
    {
        
    }

    public void totalMinedOre()
    {
        
    }
}