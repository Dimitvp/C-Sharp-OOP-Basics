public class HardTyre : Tyre
{
    public HardTyre(double hardness) 
        : base(hardness)
    {
        this.Degradation -= this.Hardness;
    }
    public override string GetName()
    {
        return "Hard";
    }
}