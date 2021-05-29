using blazingdocs.Domain.Propertys;
using System.Collections.Generic;

namespace blazingdocs.Domain.VirtualObjects
{
    public class VirtualObjectType
    {
        public int ObjectTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<PropertyField> PropertyFields { get; set; }

        public int? ParentId { get; set; }
        public VirtualObjectType Parent { get; set; }
        public ICollection<VirtualObjectType> Children { get; set; }

        public ICollection<VirtualObject> Objects { get; set; }
    }
}
