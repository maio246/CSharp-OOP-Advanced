using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var customStack = new CustomStack<int>();
        string command;

        while ((command = Console.ReadLine()) != "END")
        {
            var commandParams = command.Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            if (commandParams[0] == "Push")
            {
                for (int i = 1; i < commandParams.Length; i++)
                {
                    customStack.Push(int.Parse(commandParams[i]));
                }
            }
            else if (commandParams[0] == "Pop")
            {
                if (customStack.Count() == 0)
                {
                    Console.WriteLine("No elements");
                    break;
                }
                else
                {
                    customStack.Pop();
                }
            }
        }

        if (customStack.Count() != 0)
        {
            ForeachTheStack(customStack);
            ForeachTheStack(customStack);
        }
    }

    private static void ForeachTheStack(CustomStack<int> customStack)
    {
        foreach (var number in customStack)
        {
            Console.WriteLine(number);
        }
    }
}