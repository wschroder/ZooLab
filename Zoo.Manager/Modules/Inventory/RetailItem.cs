namespace Zoo.Manager.Modules.Inventory
{
    public class RetailItem
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int OnHand { get; set; }

        public RetailItem(string name, decimal unitPrice, int onHand)
        {
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.OnHand = onHand;
        }
    }
}
