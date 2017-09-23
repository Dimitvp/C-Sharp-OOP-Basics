using System;

public class Car
{
    //Hp –  an integer
    //FuelAmount – a floating-point number
    //Tyre - parameter of type Tyre

    private int hp;
    private double fuelAmount;
    private Tyre tyre;

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }


    public int HP { get { return this.hp; } protected set { this.hp = value; } }
    public Tyre Tyre { get { return this.tyre; } protected set { this.tyre = value; } }
    public double FuelAmount
    {
        get { return this.fuelAmount; }
        protected set
        {
            if (value < 0 )
            {
                throw new ArgumentException($"Out of fuel");
            }
            this.fuelAmount = value;
        }
    }
}