using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class ObjectType
    {
        public int ObjectTypeId { get; set; }
        public string Name { get; set; }
        
        public ICollection<PropertyField> PropertyFields { get; set; }

        public int? ParentObjectTypeId { get; set; }
        public ObjectType Parent { get; set; }
        public ICollection<ObjectType> Children { get; set; }

        public ICollection<Object> Objects { get; set; }
    }
}
