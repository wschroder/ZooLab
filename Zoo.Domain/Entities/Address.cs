namespace Zoo.Domain.Entities
{
    public class Address: EntityBase
    {
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public StateEnum State { get; set; }
        public ZipCode Zip { get; set; }
        public string CountryCode { get; set; }
    }
}