using blazingdocs.Domain.Categories;
using blazingdocs.Domain.PhysicalObjects;
using blazingdocs.Domain.Propertys;
using System;
using System.Collections.Generic;

namespace blazingdocs.Domain.VirtualObjects
{
    public class VirtualObject
    {
        public int ObjectId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public PhysicalObject PhysicalObject { get; set; }

        public int? ObjectTypeId { get; set; }
        public VirtualObjectType ObjectType { get; set; }

        public ICollection<Property> Properties { get; set; }

        public ICollection<File> Files { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
