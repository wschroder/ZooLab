using System.Collections.Generic;

namespace Zoo.Domain.Entities
{
    public class Category
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }
    }
}
