using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _01HarestingFields
{
    using System;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            string inputCommand;
            var methods =
                typeof(HarvestingFields)
                    .GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            List<string> result = new List<string>(); 
            while ((inputCommand = Console.ReadLine()) != "HARVEST")
            {
                switch (inputCommand)
                {
                    case "protected":
                        methods
                            .Where(m => m.IsFamily)
                            .ToList()
                            .ForEach
                            (m => result.Add($"{m.Attributes.ToString().ToLower()} {m.FieldType.Name} {m.Name}"));
                        break;
                    case "private":
                        methods
                            .Where(m => m.IsPrivate)
                            .ToList()
                            .ForEach
                            (m => result.Add($"{m.Attributes.ToString().ToLower()} {m.FieldType.Name} {m.Name}"));
                        break;
                    case "public":
                        methods
                            .Where(m => m.IsPublic)
                            .ToList()
                            .ForEach
                            (m => result.Add($"{m.Attributes.ToString().ToLower()} {m.FieldType.Name} {m.Name}"));
                        break;
                    case "all":
                        methods
                            .ToList()
                            .ForEach
                            (m => result.Add($"{m.Attributes.ToString().ToLower()} {m.FieldType.Name} {m.Name}"));
                        break;
                }
                Console.WriteLine(string.Join(Environment.NewLine, result).Replace("family", "protected"));
result = new List<string>();
            }
        }
    }
}
