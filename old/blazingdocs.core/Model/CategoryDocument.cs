using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class CategoryDocument
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int DocumentId { get; set; }
        public Document Document { get; set; }
    }
}
