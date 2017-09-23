using System;
using System.Linq;

class Engine
{
    public void Run()
    {
        var nationsBuilder = new NationsBuilder();
        var isRunning = true;

        while (isRunning)
        {
            var commandsTokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = commandsTokens[0];
            commandsTokens.Remove(commandsTokens[0]);

            switch (command)
            {
                case "Bender":
                    nationsBuilder.AssignBender(commandsTokens);
                    break;
                case "Monument":
                    nationsBuilder.AssignMonument(commandsTokens);
                    break;
                case "Status":
                    Console.WriteLine(nationsBuilder.GetStatus(commandsTokens[0]));
                    break;
                case "War":
                    nationsBuilder.IssueWar(commandsTokens[0]);
                    break;
                case "Quit":
                    Console.WriteLine(nationsBuilder.GetWarsRecord());
                    isRunning = false;
                    break;
            }
        }
    }
}