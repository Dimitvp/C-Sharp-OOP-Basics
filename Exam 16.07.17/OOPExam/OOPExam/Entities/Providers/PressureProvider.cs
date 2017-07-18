using System;

public class PressureProvider : Provider
{
    public PressureProvider(string id, double energyOutput) 
        : base(id, energyOutput)
    {
        base.EnergyOutput += (this.EnergyOutput * 50) / 100;
    }


    //protected double EnergyOutput
    //{
    //    set
    //    {
    //        var energy = value + value * 50 / 100;
    //        if (energy < 0 || energy >= 10000)
    //        {
    //            throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
    //        }
    //        this.EnergyOutput = energy;
    //    }
    //}

    //UPON INITIALIZATION, increases its energyOutput by 50 %.
}