using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class CategoryObject
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int ObjectId { get; set; }
        public Object Object { get; set; }
    }
}
