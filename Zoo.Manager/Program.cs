using System;
using Unity;
using Zoo.Domain.Managers.Menu;
using Unity.Resolution;

namespace ZooManager
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
