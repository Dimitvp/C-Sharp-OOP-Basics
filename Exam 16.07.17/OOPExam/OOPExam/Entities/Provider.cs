using System;
using System.Text;

public abstract class Provider
{
    private string id;
    private double energyOutput;

    protected Provider(string id, double energyOutput)
    {
        this.id = id;
        this.energyOutput = energyOutput;
    }

    protected string Id
    {
        get { return this.id; }
        set
        {
            this.id = value;
        }
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (value < 0 && value >= 10000)
            {
                throw new ArgumentException("Provider is not registered, because of it's EnergyOutput");
            }
            this.energyOutput = value;
        }
    }

    //Provider is not registered, because of it's {propertyName}

    public override string ToString()
    {
        var sb = new StringBuilder();
        return sb.ToString();
    }
}