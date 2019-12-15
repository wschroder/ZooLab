using System;

namespace Zoo.Common
{
    public static class ConsoleLogger
    {
        public static void WriteError(string msg)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(msg);
            Console.WriteLine();
            Console.ForegroundColor = oldColor;
        }
    }
}
