public class AggressiveDriver : Driver
{
    private double fuelConsumptionPerKm = 2.7;
    public AggressiveDriver(string name, Car car) 
        : base(name, car)
    {
        this.FuelConsumptionPerKm = this.fuelConsumptionPerKm;
        base.Speed *= 1.3;
    }

    public override double GetTotalTime(int trackLength)
    {
        return this.TotalTime += 60 / (trackLength / this.Speed);
    }
}