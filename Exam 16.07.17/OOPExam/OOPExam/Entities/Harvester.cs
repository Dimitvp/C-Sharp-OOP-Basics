using System;
using System.Text;

public abstract class Harvester
{
    private string id;
    private double oreOutput;
    private double energyRequirement;

    protected Harvester(string id, double oreOutput, double energyRequirement)
    {
        this.id = id;
        this.oreOutput = oreOutput;
        this.energyRequirement = energyRequirement;
    }

    protected string Id
    {
        get { return this.id; }
        set
        {
            this.id = value;
        }
    }

    public double OreOutput
    {
        get { return this.oreOutput; }

        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(OreOutput)}");
            }
            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return this.energyRequirement; }
        protected set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
            }
            this.energyRequirement = value;
        }
    }
    public override string ToString()
    {
        string harvesterType = this.GetType().Name;

        return $"Successfully registreted {harvesterType} Harveste - {this.id}";
    }
    //Successfully registreted Sonic Harvester - AS-51
}