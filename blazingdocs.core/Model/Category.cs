using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public List<CategoryDocument> CategoryDocuments { get; set; }
    }
}
