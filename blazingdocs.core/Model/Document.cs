using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class Document
    {
        public int DocumentId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public List<Property> Properties { get; set; }
        public List<File> Files { get; set; }

        public List<CategoryDocument> CategoryDocuments { get; set; }
    }
}
