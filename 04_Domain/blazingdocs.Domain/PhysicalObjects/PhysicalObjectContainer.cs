using System.Collections.Generic;

namespace blazingdocs.Domain.PhysicalObjects
{
    public class PhysicalObjectContainer
    {
        public int PhysicalObjectContainerId { get; set; }
        public string Name { get; set; }

        public int? ParentId { get; set; }
        public PhysicalObjectContainer Parent { get; set; }
        public ICollection<PhysicalObjectContainer> Children { get; set; }
    }
}
