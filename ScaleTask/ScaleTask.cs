using System;

public class ScaleTask
{
    public static void Main()
    {
        Scale<int> scale = new Scale<int>(1, 2);
        Console.WriteLine(scale.GetHavier());
    }
}

