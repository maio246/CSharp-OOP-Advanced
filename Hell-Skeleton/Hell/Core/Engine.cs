using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Engine
{
    private IInputReader reader;
    private IOutputWriter writer;
    private HeroManager heroManager;

    public Engine(IInputReader reader, IOutputWriter writer, HeroManager heroManager)
    {
        this.reader = reader;
        this.writer = writer;
        this.heroManager = heroManager;
    }

    public void Run()
    {
        bool isRunning = true;

        while (isRunning)
        {
            string inputLine = this.reader.ReadLine();
            List<string> arguments = this.parseInput(inputLine);
            this.writer.WriteLine(this.processInput(arguments));
            isRunning = !this.ShouldEnd(inputLine);
        }
    }

    private List<string> parseInput(string input)
    {
        return input.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
    }

    private string processInput(List<string> arguments)
    {
        string command = arguments[0];
        arguments.RemoveAt(0);


        Type commandInstance = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name == command + "Command");

        object[] commandParams =
        {
            arguments, heroManager
        };

        Command currentCommand = (Command) Activator.CreateInstance(commandInstance, commandParams);

        return currentCommand.Execute();
    }

    private bool ShouldEnd(string inputLine)
    {
        return inputLine.Equals("Quit");
    }
}