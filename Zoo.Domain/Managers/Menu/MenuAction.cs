using System;

namespace Zoo.Domain.Managers.Menu
{
    public class MenuAction : IMenuItem
    {
        public string Name { get; }

        private readonly Action action;

        public MenuAction(string name, Action action)
        {
            this.Name = name;
            this.action = action;
        }
            
        public void OnSelect()
        {
            this.action();
        }
    }
}
