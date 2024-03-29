﻿namespace blazingdocs.core.Model
{
    public class PhysicalObject
    {
        public int PhysicalObjectId { get; set; }
        public int? IndexInContainer { get; set; }

        public int PhysicalObjectContainerId { get; set; }
        public PhysicalObjectContainer PhysicalObjectContainer { get; set; } = null!;

        public int VirtualObjectId { get; set; }
        public VirtualObject VirtualObject { get; set; } = null!;
    }
}
