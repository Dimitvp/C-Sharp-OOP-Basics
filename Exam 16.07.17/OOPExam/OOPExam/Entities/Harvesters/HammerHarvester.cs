using System;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput += (this.OreOutput * 200) / 100;
        this.EnergyRequirement *= 2;
    }

    //protected double OreOutput
    //{

    //    set
    //    {
    //        var oreOut = value + value * 200 / 100;
    //        if (oreOut < 0 || oreOut > 20000)
    //        {
    //            throw new ArgumentException($"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
    //        }
    //        this.OreOutput = oreOut;
    //    }
    //}

    //protected double EnergyRequirement
    //{
    //    set
    //    {
    //        var enrgRequ = value + value * 100 / 100;
    //        if (enrgRequ < 0 || enrgRequ > 20000)
    //        {
    //            throw new ArgumentException($"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
    //        }
    //        this.EnergyRequirement = enrgRequ;
    //    }

    //}

    //UPON INITIALIZATION, increases its oreOutput by 200 %, and increases its energyRequirement by 100 %
    //(X* 50) / 100
}