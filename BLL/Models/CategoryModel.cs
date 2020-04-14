using System.Collections.Generic;

namespace BLL.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public ICollection<ProductionModel> Productions { get; set; }
    }
}