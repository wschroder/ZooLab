using System;
using System.Collections.Generic;

namespace Zoo.Domain.Managers.Menu
{
    public class MenuBuilder : IMenuBuilder
    {
        private Stack<MenuPage> pageStack = new Stack<MenuPage>();

        private MenuPage currentMenuPage
        {
            get
            {
                if (this.pageStack.Count==0)
                {
                    throw new ApplicationException("Page stack is empty");
                }
                return this.pageStack.Peek();
            }            
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Top level menu title</param>
        public MenuBuilder(string name)
        {
            MenuPage subPage = new MenuPage(name, string.Empty);
            this.pageStack.Push(subPage);
        }

        public MenuBuilder PushPage(string name)
        {
            MenuPage subPage = new MenuPage(name, this.currentMenuPage.BreadcrumbPath);
            currentMenuPage.AddMenuItem(subPage);
            this.pageStack.Push(subPage);
            return this;
        }

        public MenuBuilder AddMenuItem<TModule>(string name) where TModule: IRunnable, new()
        {
            MenuAction<TModule> newItem = new MenuAction<TModule>(name);
            currentMenuPage.AddMenuItem(newItem);
            return this;
        }

        public MenuBuilder PopPage()
        {
            if (this.pageStack.Count == 0)
            {
                throw new ApplicationException("Attempt to pop more subpage when stack is empty.");
            }
            this.pageStack.Pop();
            return this;
        }

        public MenuBuilder ShowMenu()
        {
            this.currentMenuPage.OnSelect();
            return this;
        }
    }
}
