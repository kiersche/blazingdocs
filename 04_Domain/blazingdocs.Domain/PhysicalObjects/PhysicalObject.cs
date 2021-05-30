using blazingdocs.Domain.VirtualObjects;

namespace blazingdocs.Domain.PhysicalObjects
{
    public record PhysicalObject(
        PhysicalObjectId PhysicalObjectId,
        IndexInContainer? IndexInContainer,
        PhysicalObjectContainer PhysicalObjectContainer,
        VirtualObject VirtualObject);
}
