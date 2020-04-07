using System.Collections.Generic;

namespace DAL.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public ICollection<Production> Productions { get; set; }
    }
}