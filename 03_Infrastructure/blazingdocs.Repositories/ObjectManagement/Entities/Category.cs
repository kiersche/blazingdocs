using System.Collections.Generic;

namespace blazingdocs.core.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<VirtualObject> Objects { get; set; } = null!;
    }
}
