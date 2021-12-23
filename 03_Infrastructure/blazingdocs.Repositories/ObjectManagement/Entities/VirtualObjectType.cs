using System.Collections.Generic;

namespace blazingdocs.core.Model
{
    public class VirtualObjectType
    {
        public int VirtualObjectTypeId { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<PropertyField> PropertyFields { get; set; } = null!;

        public int? ParentId { get; set; }
        public VirtualObjectType? Parent { get; set; }
        public ICollection<VirtualObjectType> Children { get; set; } = null!;

        public ICollection<VirtualObject> Objects { get; set; } = null!;
    }
}
