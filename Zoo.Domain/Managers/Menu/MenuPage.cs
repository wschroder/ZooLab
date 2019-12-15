using System;
using System.Collections.Generic;
using Zoo.Common;

namespace Zoo.Domain.Managers.Menu
{
    public class MenuPage : IMenuItem
    {
        public string Name { get; }

        private List<IMenuItem> menuItems = new List<IMenuItem>();

        /// <summary>
        /// Consructor
        /// </summary>
        public MenuPage(string name)
        {
            this.Name = name;
            this.menuItems = new List<IMenuItem>();
        }

        public void AddMenuItem(IMenuItem item)
        {
            this.menuItems.Add(item);
        }

        public void OnSelect()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(this.Name);
                Console.WriteLine();
                int i = 0;
                foreach (IMenuItem item in this.menuItems)
                {
                    Console.WriteLine($"{++i}: {item.Name}");
                }
                Console.WriteLine();
                Console.WriteLine("x: Exit");
                Console.WriteLine();
                Console.Write("Option: ");
                ConsoleKeyInfo key = Console.ReadKey();

                string keyStr = key.KeyChar.ToString();

                if (keyStr.ToUpper() == "X")
                {
                    return;
                }
                if (int.TryParse(keyStr, out int keyNum))
                {
                    keyNum--;
                    if ((keyNum >= 0) && (keyNum < this.menuItems.Count))
                    {
                        IMenuItem chosenItem = this.menuItems[keyNum];
                        try
                        {
                            chosenItem.OnSelect();
                        }
                        catch (Exception ex)
                        {
                            string msg = ex.ToString();
                            ConsoleLogger.WriteError(msg);
                        }
                        continue;
                    }
                }
                ConsoleLogger.WriteError("Invalid option.  Hit any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
