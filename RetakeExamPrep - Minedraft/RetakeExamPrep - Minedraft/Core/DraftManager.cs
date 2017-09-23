using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

public class DraftManager
{
    //private Dictionary<string, Workers> workers;
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private double modeEnergyFactor;
    private double modeOutputFactor;
    private double totalEnergyStored;
    private double totalMinedOre;

    public DraftManager()
    {
        //this.workers = new Dictionary<string, Workers>()
        //{
        //    {"Sonic", new Workers()},
        //    {"Hammer", new Workers()}
        //};
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        modeEnergyFactor = 1.0;
        modeOutputFactor = 1.0;
    }

    public string RegisterHarvester(List<string> arguments)
    {
        var id = arguments[1];
        var oreOutput = double.Parse(arguments[2]);
        var energyRequirement = double.Parse(arguments[3]);
        if (arguments[0] == "Sonic")
        {
            var sonicFactor = int.Parse(arguments[4]);
            harvesters.Add(new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor));
            return $"Successfully registered Sonic Harvester - {id}";
        }
        else // check for invalid data !!!
        {
            harvesters.Add(new HammerHarvester(id, oreOutput, energyRequirement));
            return $"Successfully registered Hammer Harvester - {id}";
        }
    }
    //private Harvester GetHarvester(List<string> arguments)
    //{
    //    var harvesterType = arguments[0];
    //    var harvesterId = arguments[1];
    //    var harvesterOreOutput = double.Parse(arguments[2]);
    //    var harvesterEnergyRequirement = double.Parse(arguments[3]);
    //    var harvesterSonicFactor = 0;
    //    if (arguments.Count.Equals(5))
    //    {
    //        harvesterSonicFactor = int.Parse(arguments[3]);
    //    }

    //    switch (harvesterType)
    //    {
    //        case "Sonic":
    //            return new SonicHarvester(harvesterId, harvesterOreOutput, harvesterEnergyRequirement, harvesterSonicFactor);
    //        case "Hammer":
    //            return new HammerHarvester(harvesterId, harvesterOreOutput, harvesterEnergyRequirement);
    //        default:
    //            throw new ArgumentException();
    //    }
    //}
    public string RegisterProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energyOutput = double.Parse(arguments[2]);

        if (type == "Solar")
        {
            providers.Add(new SolarProvider(id, energyOutput));
            return $"Successfully registered Solar Provider - {id}";
        }
        else
        {
            providers.Add(new PressureProvider(id, energyOutput));
            return $"Successfully registered Pressure Provider - {id}";
        }
    }
    //private Provider GetPovider(List<string> arguments)
    //{
    //    var providerType = arguments[0];
    //    var providerId = arguments[1];
    //    var providerenergyOutput = double.Parse(arguments[2]);


    //    switch (providerType)
    //    {
    //        case "Solar":
    //            return new SolarProvider(providerId, providerenergyOutput);
    //        case "Pressure":
    //            return new PressureProvider(providerId, providerenergyOutput);
    //        default:
    //            throw new ArgumentException();
    //    }
    //}
    public string Day()
    {
        var daylyEnergyNeed = 0.0;
        var daylyEnergyGathered = 0.0;
        var eventualOreMined = 0.0;
        var miningStarted = false;
        // loops harvester to collect energy need
        foreach (var harvester in harvesters)
        {
            daylyEnergyNeed += harvester.EnergyRequirement * modeEnergyFactor;
            eventualOreMined += harvester.OreOutput * modeOutputFactor;
        }

        // loops providers to collect energy

        foreach (var provider in providers)
        {
            daylyEnergyGathered += provider.EnergyOutput;
            totalEnergyStored += provider.EnergyOutput;
        }

        if (daylyEnergyNeed <= totalEnergyStored)
        {
            totalEnergyStored -= daylyEnergyNeed;
            totalMinedOre += eventualOreMined;
            miningStarted = true;
        }

        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {daylyEnergyGathered}");
        if (miningStarted)
        {
            sb.AppendLine($"Plumbus Ore Mined: {eventualOreMined}");
        }
        else
        {
            sb.AppendLine($"Plumbus Ore Mined: {0}");
        }

        return sb.ToString().Trim();
    }
    public string Mode(List<string> arguments)
    {
        var mode = arguments[0];

        switch (mode)
        {
            case "Full":
                this.modeEnergyFactor = 1.0;
                this.modeOutputFactor = 1.0;
                break;
            case "Half":
                this.modeEnergyFactor = 0.6;
                this.modeOutputFactor = 0.6;
                break;
            case "Energy":
                this.modeEnergyFactor = 0.0;
                this.modeOutputFactor = 0.0;
                break;
        }

        return $"Successfully changed working mode to {mode} Mode";
    }
    public string Check(List<string> arguments)
    {
        var id = arguments[0];

        foreach (var harvester in this.harvesters)
        {
            if (harvester.Id == id)
            {
                return harvester.ToString();
            }
        }

        foreach (var provider in this.providers)
        {
            if (provider.Id == id)
            {
                return provider.ToString();
            }
        }
        throw new ArgumentException($"No element found with id - {id}");
    }
    public string ShutDown()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalEnergyStored}");
        sb.AppendLine($"Total Mined Plumbus Ore: {this.totalMinedOre}");

        return sb.ToString().Trim();
    }

}