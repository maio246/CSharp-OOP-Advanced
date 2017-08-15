using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var listParams = Console.ReadLine()
            .Split()
            .Skip(1);

        var listIterator = new ListyIterator<string>(listParams);

        try
        {
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {

                    case "Print":
                        listIterator.Print();
                        break;
                    case "HasNext":
                        Console.WriteLine(listIterator.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(listIterator.Move());
                        break;
                    case "PrintAll":
                        foreach (var element in listIterator)
                        {
                            Console.Write(element + " ");
                        }
                        Console.WriteLine();
                        break;
                }
            }
        }
        catch (InvalidOperationException ex) {
            Console.WriteLine(ex.Message);
        }
    }
}