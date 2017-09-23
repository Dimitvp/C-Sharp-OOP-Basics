using System;

public abstract class Tyre
{
    //Name – a string
    //Hardness –  a floating-point number
    //Degradation - a floating-point number
    //private string name;
    private double hardness;
    private double degradation;

    protected Tyre(double hardness)
    {
        //this.name = name;
        this.hardness = hardness;
        this.Degradation = 100;
    }

    public double Hardness
    {
        get { return this.hardness; }
        protected set { this.hardness = value; }
    }

    public double Degradation
    {
        get { return this.degradation; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Blown tyre");
            }
            this.degradation = value;
        }
    }
    public abstract string GetName();
}