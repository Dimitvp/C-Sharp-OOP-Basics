public abstract class Bender
{
    private string name;
    private int power;

    protected Bender(string name, int power)
    {
        this.name = name;
        this.power = power;
    }

    public abstract double GetPower();

    public int Power { get { return this.power; }  }
    public override string ToString()
    {
        string benderType = this.GetType().Name;
        int typeEnd = benderType.IndexOf("Bender");
        benderType = benderType.Insert(typeEnd, " ");

        return $"{benderType}: {this.name}, Power: {this.Power}";
    }

    //###Air Bender: Yu, Power: 100, Aerial Integrity: 215.6
}