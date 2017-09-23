public abstract class Driver
{
    //Name – a string
    //TotalТime – a floating-point number
    //Car - parameter of type Car
    //FuelConsumptionPerKm – a floating-point number
    //Speed – a floating-point number
    private string name;
    private double totalТime;
    private Car car;
    private double fuelConsumptionPerKm;
    private double speed;

    protected Driver(string name, Car car)
    {
        this.Name = name;
        this.TotalTime = totalТime;
        this.Car = car;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
        this.Speed = (this.car.HP + this.car.Tyre.Degradation) / this.car.FuelAmount;
    }

    public string Name { get { return this.name; } protected set { this.name = value; } }
    public double TotalTime { get { return this.totalТime; } set { this.totalТime = value; } }
    public Car Car { get { return this.car; }  set { this.car = value; } }
    public double FuelConsumptionPerKm
    {
        get { return this.fuelConsumptionPerKm; }
        protected set
        {
            this.fuelConsumptionPerKm = value;
        }
    }

    public double Speed
    {
        get { return this.speed; }
        protected set
        {
            value = (this.Car.HP + this.Car.Tyre.Degradation) / this.Car.FuelAmount;
            this.speed = value;
        }
    }

    public abstract double GetTotalTime(int trackLength);
    //public abstract double GetTotalSpeed();

}