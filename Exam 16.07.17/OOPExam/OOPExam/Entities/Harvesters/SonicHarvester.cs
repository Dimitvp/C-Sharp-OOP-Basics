using System;
using System.Text;

public class SonicHarvester : Harvester
{
    private int sonicFactor;
    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor) 
        : base(id, oreOutput, energyRequirement)
    {
        this.sonicFactor = sonicFactor;
        this.EnergyRequirement /= this.sonicFactor;
    }

    //protected double SonicFactor
    //{
    //    set
    //    {
    //        if (value < 1 || value > 10)
    //        {
    //            throw new ArgumentException();
    //        }
    //    }
    //}

    //protected double EnergyRequirement
    //{
    //    //get { return this.EnergyRequirement; }
    //    set
    //    {
    //        if (value / sonicFactor <= 0 || value / sonicFactor > 20000)
    //        {
    //            throw new ArgumentException($"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
    //        }
    //        this.EnergyRequirement = value / sonicFactor;
    //    }
    //}



    //UPON INITIALIZATION, divides its given energyRequirement by its sonicFactor.
}