using Zoo.Domain.Entities;

namespace Zoo.Manager.Modules.Inventory
{
    public class Item : EntityBase
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int OnHand { get; set; }

        public Item(string name, decimal unitPrice, int onHand): base()
        {
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.OnHand = onHand;
        }
    }
}
