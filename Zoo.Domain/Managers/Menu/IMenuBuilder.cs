using System;

namespace Zoo.Domain.Managers.Menu
{
    public interface IMenuBuilder
    {
        MenuBuilder AddMenuItem<TModule>(string name) where TModule : IRunnable, new();

        MenuBuilder PopPage();

        MenuBuilder PushPage(string name);

        MenuBuilder ShowMenu();
    }
}
