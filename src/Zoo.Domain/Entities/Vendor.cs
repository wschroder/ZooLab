using System.Collections.Generic;

namespace Zoo.Domain.Entities
{
    public class Vendor: EntityBase
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Catalog> Catalogs { get; set; }
    }
}