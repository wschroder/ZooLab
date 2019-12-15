using System;
using Unity;
using Unity.Resolution;
using Zoo.Common;
using Zoo.Domain.Managers.Menu;

namespace ZooManager
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IUnityContainer container = UnityConfig.Configure();

                var menu = container.Resolve<IMenuBuilder>(new ParameterOverride("name", "Zoo Manager"));

                menu.AddMenuItem("Restaurant", () => NullMenuAction.Process())
                    .PushPage("Gift Shop")
                        .AddMenuItem("Inventory", () => NullMenuAction.Process())
                        .AddMenuItem("Reports", () => NullMenuAction.Process())
                    .PopPage()
                    .PushPage("Animals")
                        .AddMenuItem("Population", () => NullMenuAction.Process())
                        .AddMenuItem("Departments", () => NullMenuAction.Process())
                    .PopPage();

                menu.ShowMenu();
            }
            catch (Exception ex)
            {
                ConsoleLogger.WriteError(ex.ToString());
                Console.ReadKey();
            }
        }
    }
}
