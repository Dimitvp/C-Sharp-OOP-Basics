using System;

public class Car : Vehicle
{
    private const double Summer = 0.9;

    public Car(double fuel, double consumption, double tankCapacity)
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

        if ((base.Fuel + amounth) > base.TankCapacity)
        {
            throw new ApplicationException("Cannot fit fuel in tank");
        }
        base.Refuel(amounth);
    }


    public override string Drive(double distance)
    {
        var fuelCost = distance * base.Consumption;
        if (base.Fuel < fuelCost)
        {
            throw new ApplicationException("Car needs refueling");
        }
        base.Fuel -= fuelCost;
        return $"Car travelled {distance} km";
    }
}