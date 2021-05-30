using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class PhysicalObjectContainer
    {
        public int PhysicalObjectContainerId { get; set; }
        public string Name { get; set; }

        public int? ParentId { get; set; }
        public PhysicalObjectContainer? Parent { get; set; }
        public ICollection<PhysicalObjectContainer> Children { get; set; }

        public ICollection<PhysicalObject> PhysicalObjects { get; set; }
    }
}
