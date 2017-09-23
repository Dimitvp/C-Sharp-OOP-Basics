using System;
using System.Linq;

class Engine
{
    private string inputLine;
    private RaceTower raceTower;
    //private bool isRunning;

    public Engine()
    {
        //this.isRunning = true;
        this.raceTower = new RaceTower();
    }

    public int LengthOfTrack { get; set; }
    public int TotalNumOfLabs { get; set; }

    public void Run()
    {
        var totalNumOfLabs = int.Parse(Console.ReadLine());
        var lengthOfTrack = int.Parse(Console.ReadLine());
        this.raceTower.SetTrackInfo(totalNumOfLabs, lengthOfTrack);

        this.TotalNumOfLabs = totalNumOfLabs;
        
        while (totalNumOfLabs > 0)
        {
            try
            {
                inputLine = Console.ReadLine();
                var arguments = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var command = arguments[0];
                arguments.Remove(arguments[0]);

                switch (command)
                {
                    case "RegisterDriver":
                        this.raceTower.RegisterDriver(arguments);
                        break;
                    case "Leaderboard":
                        Console.WriteLine(this.raceTower.GetLeaderboard());
                        break;
                    case "CompleteLaps":
                        Console.WriteLine(this.raceTower.CompleteLaps(arguments));
                        totalNumOfLabs -= int.Parse(arguments[0]);
                        break;
                    case "Box":
                        this.raceTower.DriverBoxes(arguments);
                        break;
                    case "ChangeWeather":
                        this.raceTower.ChangeWeather(arguments);
                        break;
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}