using System.Reflection;

namespace _02BlackBoxInteger
{
    using System;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var blackBoxType = typeof(BlackBoxInt);

            var blackBoxInstance = (BlackBoxInt)Activator.CreateInstance(blackBoxType, true);

            // var blackBoxCtor = blackBoxType.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic,
            //Type.DefaultBinder, new Type[] { }, null);

            string commandInfo;


            while ((commandInfo = Console.ReadLine()) != "END")
            {
                var commandTokens = commandInfo.Split('_');

                var command = commandTokens[0];
                var numb = int.Parse(commandTokens[1]);

                blackBoxType.GetMethod(command, BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(blackBoxInstance, new object[] { numb });

                var finalValue = blackBoxType.GetField("innerValue",BindingFlags.Instance | BindingFlags.NonPublic).GetValue(blackBoxInstance);

                Console.WriteLine(finalValue.ToString());
            }
        }
    }
}
