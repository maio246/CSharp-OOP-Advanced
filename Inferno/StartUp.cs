using System;

public class StartUp
{
    public static void Main()
    {
        WeaponInventory inventory = new WeaponInventory();

        string input;

        while ((input = Console.ReadLine()) != "END")
        {
                var commandTokens = input.Split(new []{';'}, StringSplitOptions.RemoveEmptyEntries);

                var command = commandTokens[0];
                switch (command)
                {
                    case "Create":
                        inventory.Create(commandTokens[1], commandTokens[2]);
                        break;
                    case "Add":
                        inventory.Add(commandTokens[1], int.Parse(commandTokens[2]), commandTokens[3]);
                        break;
                    case "Remove":
                        inventory.Remove(commandTokens[1], int.Parse(commandTokens[2]));
                        break;
                    case "Print":
                        inventory.Print(commandTokens[1]);
                        break;
                }
        }
    }
}