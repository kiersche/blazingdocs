using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class PhysicalDocumentContainer
    {
        public int PhysicalDocumentContainerId { get; set; }
        public string Name { get; set; }
        public int NumberOfElements { get; set; }

        public int? ParentPhysicalDocumentContainerId { get; set; }
        public PhysicalDocumentContainer Parent { get; set; }
        public List<PhysicalDocumentContainer> Children { get; set; }
    }
}
