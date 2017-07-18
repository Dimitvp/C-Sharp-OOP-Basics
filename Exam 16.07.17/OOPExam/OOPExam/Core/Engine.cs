using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private DraftManager draftManager;
    private bool isRunning;

    public Engine()
    {
        isRunning = true;
        this.draftManager = new DraftManager();
    }

    public void Run()
    {
        while (this.isRunning)
        {
            string inputCommand = this.ReadInput();
            List<string> commandParameters = this.ParseInput(inputCommand);
            this.DistributeCommand(commandParameters);
        }
    }

    private void DistributeCommand(List<string> commandParameters)
    {
        string command = commandParameters[0];
        commandParameters.Remove(command);

        switch (command)
        {
            case "RegisterHarvester":
                this.draftManager.RegisterHarvester(commandParameters);
                break;
            case "RegisterProvider":
                this.draftManager.RegisterProvider(commandParameters);
                break;
            case "Day":
                string status = this.draftManager.Day();
                this.OutputWriter(status);
                break;
            case "Mode":
                this.draftManager.Mode(commandParameters);
                break;
            case "Check ":
                this.draftManager.Check(commandParameters);
                break;
            case "Shutdown":
                string record = this.draftManager.ShutDown();
                this.OutputWriter(record);
                this.isRunning = false;
                break;
        }
    }
    private void OutputWriter(string status) => Console.WriteLine(status);
    private List<string> ParseInput(string inputCommand)
    {
        return inputCommand.Split(' ').ToList();
    }

    private string ReadInput()
    {
        return Console.ReadLine();
    }
}