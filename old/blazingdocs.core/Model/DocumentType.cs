using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class DocumentType
    {
        public int DocumentTypeId { get; set; }
        public string Name { get; set; }
        
        public List<PropertyField> PropertyFields { get; set; }

        public int? ParentDocumentTypeId { get; set; }
        public DocumentType Parent { get; set; }
        public List<DocumentType> Children { get; set; }
    }
}
