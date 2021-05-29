using blazingdocs.Domain.VirtualObjects;
using System.Collections.Generic;

namespace blazingdocs.Domain.Categories
{
    public class Category
    {
        public CategoryId CategoryId { get; set; }
        public CategoryName Name { get; set; }
        public ICollection<VirtualObject> Objects { get; set; }
    }
}
