using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RaceTower
{

    private HashSet<Driver> drivers;
    private Tyre tyre;
    private Car car;
    private string weather;
    private int labsCounter;

    //private int trackLengt;

    public RaceTower()
    {
        this.drivers = new HashSet<Driver>();
    }


    public int LapsNumber { get; set; }
    public int TrackLength { get; set; }
    public Car Car { get; set; }
    public Tyre Tyre { get; set; }

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.LapsNumber = lapsNumber;
        this.TrackLength = trackLength;
    }
    public void RegisterDriver(List<string> commandArgs)
    {
        //tyreType – a string
        //tyreHardness – a floating-point number
        //If the type of tyre is Ultrasoft, you will receive 1 extra parameter:
        //grip

        var name = commandArgs[1];
        var hp = int.Parse(commandArgs[2]);
        var fuelAmount = double.Parse(commandArgs[3]);
        var tyreType = commandArgs[4];
        var tyreHardness = double.Parse(commandArgs[5]);

        if (tyreType == "Ultrasoft")
        {
            var grip = double.Parse(commandArgs[6]);
            this.tyre = new UltrasoftTyre(tyreHardness, grip);
        }
        else
        {
            this.tyre = new HardTyre(tyreHardness);
        }

        var car = new Car(hp, fuelAmount, this.tyre);
        if (commandArgs[0] == "Aggressive")
        {
            this.drivers.Add(new AggressiveDriver(name, car));
        }
        else
        {
            this.drivers.Add(new EnduranceDriver(name, car));
        }
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        //driversName - a string specifying which driver boxes
        //tyreType / fuelAmount - a string specifying the type of the new tyre / a floating - point specifying how much fuel is refilled

        var reasonToBox = commandArgs[0];
        var driversName = commandArgs[1];
        var tyreHardness = string.Empty;
        var grip = string.Empty;
        var fuelAmount = 0.0;
        if (reasonToBox == "ChangeTyres")
        {
            var tyreType = commandArgs[2];
            tyreHardness = commandArgs[3];
            if (tyreType == "Ultrasoft")
            {
                grip = commandArgs[4];
            }
            foreach (var driver in this.drivers)
            {
                if (driver.Name == driversName)
                {
                    driver.TotalTime = +20;
                    //tyre.De += tyreHardness;
                }
            }
        }
        else
        {
            fuelAmount = double.Parse(commandArgs[2]);
            foreach (var driver in this.drivers)
            {
                if (driver.Name == driversName)
                {
                    driver.TotalTime = +20;

                    //driver.Car = new Car(fuelAmount);
                    //driver.Car.FuelAmount += fuelAmount;
                }
            }
        }     
    }

    public string CompleteLaps(List<string> commandArgs)
    {

        var sb = new StringBuilder();
        var numberOfLaps = int.Parse(commandArgs[0]);
        if (numberOfLaps > LapsNumber)
        {
            sb.AppendLine($"There is no time! On lap {this.labsCounter}.");
        }

        for (int i = 0; i < numberOfLaps; i++)
        {
            foreach (var driver in this.drivers)
            {
                driver.GetTotalTime(this.TrackLength);
                //driver.FuelAmount -= this.TrackLength * driver.FuelConsumptionPerKm;
                //driver.Car.Tyre.Degradation;
            }
            this.labsCounter++;
        }
        //check for overtaking opportunities. 

       

        return sb.ToString().Trim();
    }

    public string GetLeaderboard()
    {
        var counter = 1;
        var sb = new StringBuilder();
        sb.AppendLine($"Lap {this.labsCounter}/{this.LapsNumber}");
        foreach (var driver in this.drivers.OrderBy(d => d.TotalTime))
        {
            sb.AppendLine($"{counter}. {driver.Name} {driver.TotalTime:f3}");
            counter++;
        }
        return sb.ToString();
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        var weather = commandArgs[0];

        switch (weather)
        {
            case "Sunny":
                this.weather = "Sunny";
                break;
            case "Foggy":
                this.weather = "Foggy";
                break;
            case "Rainy":
                this.weather = "Rainy";
                break;
        }
    }

}