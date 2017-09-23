using System;
using System.Text;

public abstract class Provider
{
    private string id;
    private double energyOutput;

    protected Provider(string id, double energyOutput)
    {
        this.id = id;
        this.EnergyOutput = energyOutput;
    }

    public string Id
    {
        get { return this.id; }
        protected set { this.id = value; }
    }

    public double EnergyOutput
    {
        get
        {
            return this.energyOutput;
        }
        protected set
        {
            if (value < 0 || value >= 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(this.EnergyOutput)}");
            }
            this.energyOutput = value;
        }
    }

    public abstract string GetName();

    public override string ToString()
    {
        var sb = new StringBuilder();
        //“{ type} Provider – { id}
        //Energy Output: { energyOutput}”
        sb.AppendLine($"{this.GetName()} Provider - {this.id}");
        sb.AppendLine($"Energy Output: {this.energyOutput}");

        return sb.ToString().Trim();
    }
}