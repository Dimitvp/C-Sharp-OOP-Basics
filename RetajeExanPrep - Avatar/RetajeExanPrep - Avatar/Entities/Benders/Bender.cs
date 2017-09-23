using System.Text;

public abstract class Bender
{
    private string name;
    private int power;

    protected Bender(string name, int power)
    {
        this.name = name;
        this.power = power;
    }

    public string Name { get { return this.name; } protected set { this.name = value; } }
    public int Power { get { return this.power; } protected set { this.power = value; } }

    public abstract double GetPower();
    public override string ToString()
    {
        var getType = this.GetType().Name;
        var getEnd = getType.IndexOf("Bender");
        getType = getType.Insert(getEnd, " ");
        return $"{getType}: {this.name}, Power: {this.power}";
    }
}