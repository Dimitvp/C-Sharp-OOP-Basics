public class UltrasoftTyre : Tyre
{
    private double grip;
    public UltrasoftTyre(double hardness, double grip) 
        : base(hardness)
    {
        this.grip = grip;
        this.Degradation -= this.Hardness + this.grip;
    }


    public override string GetName()
    {
        return "Ultrasoft";
    }
}