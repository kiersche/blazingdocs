using System.Collections.Generic;

namespace blazingdocs.core.Model
{
    public class PhysicalObjectContainer
    {
        public int PhysicalObjectContainerId { get; set; }
        public string Name { get; set; } = null!;

        public int? ParentId { get; set; }
        public PhysicalObjectContainer? Parent { get; set; }
        public ICollection<PhysicalObjectContainer> Children { get; set; } = null!;

        public ICollection<PhysicalObject> PhysicalObjects { get; set; } = null!;
    }
}
