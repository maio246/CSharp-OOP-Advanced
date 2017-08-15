using System.Collections.Generic;

namespace StrategyPattern.Comparators
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            int result = x.Name.Length - y.Name.Length;
            if (result == 0)
            {
                var firstPersonChar = char.ToLower(x.Name[0]);
                var secondPersonChar = char.ToLower(y.Name[0]);

                result = firstPersonChar.CompareTo(secondPersonChar);
            }

            return result;
        }
    }
}
