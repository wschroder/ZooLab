using System;
using System.Collections.Generic;

namespace Zoo.Common
{
    public static class ConsoleLogger
    {
        private readonly static Stack<ConsoleColor> colorStack = new Stack<ConsoleColor>();
        
        public static void WriteError(string msg)
        {
            PushColor(ConsoleColor.DarkRed);
            Console.WriteLine(msg);
            Console.WriteLine();
            PopColor();
        }

        public static void PushColor(ConsoleColor cyan)
        {
            colorStack.Push(Console.ForegroundColor);
            Console.ForegroundColor = cyan;
        }

        public static void PopColor()
        {
            if (colorStack.Count==0)
            {
                throw new InvalidOperationException("Attempt made to pop empty color stack.");
            }
            Console.ForegroundColor = colorStack.Pop();
        }
    }
}
