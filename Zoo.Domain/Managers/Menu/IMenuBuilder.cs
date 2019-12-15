using System;

namespace Zoo.Domain.Managers.Menu
{
    public interface IMenuBuilder
    {
        MenuBuilder AddMenuItem(string name, Action action);

        MenuBuilder PopPage();

        MenuBuilder PushPage(string name);

        MenuBuilder ShowMenu();
    }
}
