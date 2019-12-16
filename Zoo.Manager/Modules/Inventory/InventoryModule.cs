using System;
using System.Collections.Generic;
using Zoo.Common;
using Zoo.Domain.Managers.Menu;

namespace Zoo.Manager.Modules.Inventory
{
    public class InventoryModule : IRunnable
    {

        private readonly List<Item> Inventory = new List<Item>();

        public InventoryModule()
        {
            this.Inventory = new List<Item>
            {

                new Item(name: "Rubics Cube", unitPrice: 3.50m, onHand: 25),
                new Item(name: "Red Sweaters", unitPrice: 17.95m, onHand: 5),
                new Item(name: "Golf Clubs", unitPrice: 75.00m, onHand: 3),
                new Item(name: "Bowling Shoes", unitPrice: 19.95m, onHand: 8),
            };
        }
        public void Run()
        {
            Console.Clear();
            foreach(var item in this.Inventory)
            {
                Console.WriteLine($"{item.Name,-20} {item.UnitPrice,10:c}  {item.OnHand,5}");
            }
            Console.WriteLine();
            ConsoleLogger.PushColor(ConsoleColor.DarkGray);
            Console.WriteLine("Hit any key to continue...");
            ConsoleLogger.PopColor();
        }
    }
}
