using System;
using Zoo.Domain.Managers.Menu;

namespace Zoo.Manager.Modules
{
    public class NullModule : IRunnable
    {
        public void Run()
        {
            Console.WriteLine(@"


[Nothing happening here]

Press any key to continue...

");
            Console.ReadKey();
        }
    }
}