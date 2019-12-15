using System;
using Unity;
using Unity.Resolution;
using Zoo.Common;
using Zoo.Domain.Managers.Menu;
using Zoo.Manager.Modules;
using Zoo.Manager.Modules.Inventory;

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

                menu.AddMenuItem<NullModule>("Restaurant")
                    .PushPage("Gift Shop")
                        .AddMenuItem<InventoryModule>("Inventory")
                    .PopPage()
                    .PushPage("Animals")
                        .AddMenuItem<NullModule>("Population")
                        .AddMenuItem<NullModule>("Departments")
                    .PopPage()
                    .PushPage("HR")
                        .AddMenuItem<NullModule>("Payroll")
                        .AddMenuItem<NullModule>("Employee Roster")
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
