using System;

public abstract class Vehicle
{
    private double fuel;
    private double consumption;
    private double tankCapacity;

    protected double TankCapacity
    {
        get { return this.tankCapacity; }
        set { this.tankCapacity = value; }
    }


    protected Vehicle(double fuel)
    {
        this.Fuel = fuel;
    }
    protected double Consumption
    {
        get { return this.consumption; }
        set { this.consumption = value; }
    }

    public double Fuel
    {
        get { return this.fuel; }
        protected set { this.fuel = value; }
    }

    public virtual void Refuel(double amounth)
    {
        this.Fuel += amounth;
    }
    public abstract string Drive(double distance);
}