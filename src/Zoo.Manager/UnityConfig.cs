using Unity;
using Zoo.Domain.Managers.Menu;

namespace ZooManager
{
    public static class UnityConfig
    {
        private static IUnityContainer container = new UnityContainer();

        public static IUnityContainer Configure()
        {
            container.RegisterType<IMenuBuilder, MenuBuilder>();

            return container;
        }
    }
}
