using System.Collections.Generic;

public class CarManager
{
    private Dictionary<int, Car> cars;
    private Dictionary<int, Race> races;
    private Garage garage;

    private List<int> racesClosed;

    public CarManager()
    {
        this.cars = new Dictionary<int, Car>();
        this.races = new Dictionary<int, Race>();
        this.garage = new Garage();
        this.racesClosed = new List<int>();
    }

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        
    }

    public string Check(int id)
    {
        return cars[id].ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        
    }

    public void Participate(int carId, int raceId)
    {
        
    }

    public string Start(int id)
    {
        if (races[id].Participants.Count == 0)
        {
            return "Cannot start the race with zero participants.";
        }
        var result = races[id].StartRace();
        racesClosed.Add(id);
        //races.Remove(id);
        return result;
    }
    public void Park(int id) { }
    public void Unpark(int id) { }
    public void Tune(int tuneIndex, string addOn) { }
}