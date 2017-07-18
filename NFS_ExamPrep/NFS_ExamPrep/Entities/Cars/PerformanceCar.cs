using System.Collections.Generic;
using System.Text;

public class PerformanceCar : Car
{

    private List<string> addOns;
    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) 
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.addOns = new List<string>();
    }

    private void modifyStats()
    {
        this.HorsePower = this.HorsePower + this.HorsePower * 50 / 100;
        this.Suspension = this.Suspension - this.Suspension * 25 / 100;
    }
    public IReadOnlyList<string> AddOns
    {
        get { return this.addOns.AsReadOnly(); }
    }
    public override void Tune(int tuneIndex, string tuneAddOn)
    {
        base.Tune(tuneIndex, tuneAddOn);

        this.addOns.Add(tuneAddOn);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder(base.ToString());
        sb.Append(string.Format("Add-ons: {0}", this.AddOns.Count > 0 ? string.Join(", ", this.AddOns) : "None"));
        return sb.ToString();
    }
}