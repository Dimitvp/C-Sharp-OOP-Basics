public class EarthBender : Bender
{
    private double groundSaturation;

    public EarthBender(string name, int power, double groundSaturation) 
        : base(name, power)
    {
        this.groundSaturation = groundSaturation;
    }
    public override string ToString() => $"{base.ToString()}, Ground Saturation: {this.groundSaturation:f2}";
    public override double GetPower()
    {
        return this.groundSaturation * this.Power;
    }
}