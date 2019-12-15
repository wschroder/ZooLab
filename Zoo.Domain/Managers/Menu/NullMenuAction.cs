using System;

namespace Zoo.Domain.Managers.Menu
{
    public static class NullMenuAction
    {
        public static void Process()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("[Nothing happening here]");

            Console.WriteLine("Press any key to continue...");

            Console.ReadKey();
        }
    }
}
