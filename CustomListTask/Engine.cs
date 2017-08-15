using System;

public class Engine
{

    public void CommandInterpreter()
    {
        string command;
        CustomList<string> list = new CustomList<string>();

        while ((command = Console.ReadLine()) != "END")
        {
            var commandTokens = command.Split();

            var currCommand = commandTokens[0];

            switch (currCommand)
            {
                case "Add":
                    list.Add(commandTokens[1]);
                    break;
                case "Remove":
                    list.Remove(int.Parse(commandTokens[1]));
                    break;
                case "Contains":
                    Console.WriteLine(list.Contains(commandTokens[1]));
                    break;
                case "Swap":
                    list.Swap(int.Parse(commandTokens[1]), int.Parse(commandTokens[2]));
                    break;
                case "Greater":
                    Console.WriteLine(list.CountGreaterThan(commandTokens[1]));
                    break;
                case "Max":
                    Console.WriteLine(list.Max());
                    break;
                case "Min":
                    Console.WriteLine(list.Min());
                    break;
                case "Print":
                    foreach (var element in list)
                    {
                        Console.WriteLine(element);
                    }
                    break;
                case "Sort":
                    list = Sorter.Sort<string>(list);
                    break;
            }
        }
    }
}
