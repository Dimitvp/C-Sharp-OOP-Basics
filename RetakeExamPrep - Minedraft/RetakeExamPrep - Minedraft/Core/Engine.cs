using System;
using System.Linq;

public class Engine
{
    private string inputLine;
    private bool isRunning;
    private DraftManager draftManager;

    public Engine()
    {
        this.isRunning = true;
        this.draftManager = new DraftManager();
    }

    public void Run()
    {
        while (isRunning)
        {
            try
            {
                inputLine = Console.ReadLine();
                var arguments = inputLine.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
                var command = arguments[0];
                arguments.Remove(arguments[0]);

                switch (command)
                {
                    case "RegisterHarvester":
                        Console.WriteLine(draftManager.RegisterHarvester(arguments));
                        break;
                    case "RegisterProvider":
                        Console.WriteLine(draftManager.RegisterProvider(arguments));
                        break;
                    case "Day":
                        Console.WriteLine(draftManager.Day());
                        break;
                    case "Mode":
                        Console.WriteLine(draftManager.Mode(arguments));
                        break;
                    case "Check":
                        Console.WriteLine(draftManager.Check(arguments));
                        break;
                    case "Shutdown":
                        Console.WriteLine(draftManager.ShutDown());
                        this.isRunning = false;
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