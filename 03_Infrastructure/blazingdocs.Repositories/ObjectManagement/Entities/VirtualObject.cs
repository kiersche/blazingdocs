using System;
using System.Collections.Generic;

namespace blazingdocs.core.Model
{
    public class VirtualObject
    {
        public int VirtualObjectId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public PhysicalObject? PhysicalObject { get; set; }

        public int? VirtualObjectTypeId { get; set; }
        public VirtualObjectType? VirtualObjectType { get; set; }

        public ICollection<Property> Properties { get; set; } = null!;
        
        public ICollection<File> Files { get; set; } = null!;

        public ICollection<Category> Categories { get; set; } = null!;
    }
}
