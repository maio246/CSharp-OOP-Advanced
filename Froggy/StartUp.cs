using System;
using System.Linq;

namespace Froggy
{
    public class StartUp
    {
        public static void Main()
        {
            var stones = Console.ReadLine().Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

            var myLake = new Lake(stones);

            Console.WriteLine(string.Join(", ", myLake));

        }
    }
}
