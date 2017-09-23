public class EnduranceDriver : Driver
{
    private double fuelConsumptionPerKm = 1.5;
    public EnduranceDriver(string name, Car car)
        : base(name, car)
    {
        this.FuelConsumptionPerKm = this.fuelConsumptionPerKm;
    }

    public override double GetTotalTime(int trackLength)
    {
        return this.TotalTime += 60 / (trackLength / this.Speed);
    }

}