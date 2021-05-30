using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class VirtualObjectType
    {
        public int VirtualObjectTypeId { get; set; }
        public string Name { get; set; }
        
        public ICollection<PropertyField> PropertyFields { get; set; }

        public int? ParentId { get; set; }
        public VirtualObjectType Parent { get; set; }
        public ICollection<VirtualObjectType> Children { get; set; }

        public ICollection<VirtualObject> Objects { get; set; }
    }
}
