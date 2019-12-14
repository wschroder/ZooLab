using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace ZooManager
{
    public static class UnityConfig
    {
        private static IUnityContainer container = new UnityContainer();

        public static IUnityContainer Configure()
        {
            return container;
        }
    }
}
