using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class ObjectType
    {
        public int ObjectTypeId { get; set; }
        public string Name { get; set; }
        
        public List<PropertyField> PropertyFields { get; set; }

        public int? ParentObjectTypeId { get; set; }
        public ObjectType Parent { get; set; }
        public List<ObjectType> Children { get; set; }
    }
}
