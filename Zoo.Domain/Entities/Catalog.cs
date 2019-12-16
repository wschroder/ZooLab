using System.Collections.Generic;

namespace Zoo.Domain.Entities
{
    public class Catalog
    {
        public string Name { get; set; }
        public List<CatalogItem> Items { get; set; }
    }
}