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
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public string Id
    {
        get { return this.id; }
        protected set { this.id = value; }
    }

    public double OreOutput
    {
        get { return this.oreOutput; }
        protected set
        {
            if (value <= 0)
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

    public abstract string GetName();

    public override string ToString()
    {
        var sb = new StringBuilder();
        //“{ type} Harvester – { id}
        //Ore Output: { oreOutput}
        //Energy Requirement: { energyRequired}”
        sb.AppendLine($"{this.GetName()} Harvester - {this.id}");
        sb.AppendLine($"Ore Output: {this.oreOutput}");
        sb.AppendLine($"Energy Requirement: {this.energyRequirement}");

        return sb.ToString().Trim();
    }
}