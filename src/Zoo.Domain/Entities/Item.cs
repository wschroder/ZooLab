namespace Zoo.Domain.Entities
{
    public class Item: EntityBase
    {
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public string Barcode { get; set; }
    }
}
