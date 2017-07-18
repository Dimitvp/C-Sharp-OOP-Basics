using System;

public class Bus : Vehicle
{
    private const double Summer = 1.4;

    public Bus(double fuel, double consumption, double tankCapacity)
        : base(fuel)
    {
        base.Consumption = consumption;
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

    public string DriveEmpty(double distance)
    {
        var fuelCost = distance * base.Consumption;
        if (base.Fuel < fuelCost)
        {
            throw new ApplicationException("Bus needs refueling");
        }
        base.Fuel -= fuelCost;
        return $"Bus travelled {distance} km";
    }

    public override string Drive(double distance)
    {
        var fuelCost = distance * (base.Consumption + Summer);
        if (base.Fuel < fuelCost)
        {
            throw new ApplicationException("Bus needs refueling");
        }
        base.Fuel -= fuelCost;
        return $"Bus travelled {distance} km";
    }
}
