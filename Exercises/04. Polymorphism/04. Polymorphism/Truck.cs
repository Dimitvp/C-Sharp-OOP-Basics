using System;

public class Truck : Vehicle
{
    private const double Summer = 1.6;
    private const double HolePenalty = 0.95;

    public Truck(double fuel, double consumption, double tankCapacity)
        : base(fuel)
    {
        base.Consumption = consumption + Summer;
        base.TankCapacity = tankCapacity;
    }

    public override void Refuel(double amounth)
    {
        if (amounth <= 0)
        {
            throw new ApplicationException("Fuel must be a positive number");
        }
        base.Refuel(amounth * HolePenalty);
    }


    public override string Drive(double distance)
    {
        var fuelCost = distance * base.Consumption;
        if (base.Fuel < fuelCost)
        {
            throw new ApplicationException("Truck needs refueling");
        }
        base.Fuel -= fuelCost;
        return $"Truck travelled {distance} km";
    }
}