using System;
using System.Collections.Generic;
using Zoo.Common;

namespace Zoo.Domain.Managers.Menu
{
    public class MenuPage : IMenuItem
    {
        public string Name { get; }
        public string BreadcrumbPath { get; }

        private List<IMenuItem> menuItems = new List<IMenuItem>();

        /// <summary>
        /// Consructor
        /// </summary>
        public MenuPage(string name, string breadcrumbPath)
        {
            this.BreadcrumbPath = string.IsNullOrEmpty(breadcrumbPath)
                                        ? name
                                        : $"{breadcrumbPath} / {name}";
            this.Name = name;
            this.menuItems = new List<IMenuItem>();
        }

        public void AddMenuItem(IMenuItem item)
        {
            this.menuItems.Add(item);
        }

        public void OnSelect()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                ShowMenu();
                keepGoing = ProcessMenuOption();
            }
        }

        private bool ProcessMenuOption()
        {
            ConsoleKeyInfo key = Console.ReadKey();

            string keyStr = key.KeyChar.ToString();

            if (keyStr.ToUpper() == "X")
            {
                return false;
            }
            if (int.TryParse(keyStr, out int keyNum))
            {
                if ((keyNum > 0) && (keyNum <= this.menuItems.Count))
                {
                    keyNum--;

                    IMenuItem chosenItem = this.menuItems[keyNum];
                    chosenItem.OnSelect();

                    return true;
                }
            }
            ConsoleLogger.WriteError("\n\n\nInvalid option.  Hit any key to continue...");
            Console.ReadKey();
            return true;
        }

        private void ShowMenu()
        {
            try
            {
                ConsoleLogger.PushColor(ConsoleColor.Cyan);

                Console.Clear();
                DrawTitleBox(this.BreadcrumbPath);
                Console.WriteLine();
                int i = 0;
                foreach (IMenuItem item in this.menuItems)
                {
                    Console.WriteLine($" {++i}: {item.Name}");
                }
                Console.WriteLine();
                Console.WriteLine(" x: Exit");
                Console.WriteLine();
                Console.Write(" Option: ");
            }
            finally
            {
                ConsoleLogger.PopColor();
            }
        }

        private static void DrawTitleBox(string name)
        {
            int len = name.Length + 6;
            string bar = new string('-', len);
            Console.WriteLine(" +" + bar + "+");
            Console.WriteLine($" |   {name}   |");
            Console.WriteLine(" +" + bar + "+");
        }
    }
}
