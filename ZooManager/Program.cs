using System;
using Unity;

namespace ZooManager
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = UnityConfig.Configure();

            var menu = container.Resolve<IMenuManager>();

            Console.WriteLine("[Press any key to exit]");
            Console.ReadKey();
        }
    }
}
