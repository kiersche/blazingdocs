using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class PhysicalObject
    {
        public int PhysicalObjectId { get; set; }
        public int? IndexInContainer { get; set; }

        public int PhysicalObjectContainerId { get; set; }
        public PhysicalObjectContainer PhysicalObjectContainer { get; set; }

        public int VirtualObjectId { get; set; }
        public VirtualObject VirtualObject { get; set; }
    }
}
