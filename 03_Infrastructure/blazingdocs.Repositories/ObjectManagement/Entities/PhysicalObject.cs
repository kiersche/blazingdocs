using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class PhysicalObject
    {
        public int PhysicalDocumentId { get; set; }
        public int NumberOfPages { get; set; }

        public int PhysicalDocumentContainerId { get; set; }
        public PhysicalDocumentContainer PhysicalDocumentContainer { get; set; }
        public int IndexInContainer { get; set; }

        public int DocumentId { get; set; }
        public Document Document { get; set; }
    }
}
