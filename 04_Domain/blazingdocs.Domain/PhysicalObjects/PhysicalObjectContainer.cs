using System.Collections.Generic;

namespace blazingdocs.Domain.PhysicalObjects
{
    public record PhysicalObjectContainer(
        PhysicalObjectContainerId PhysicalObjectContainerId,
        PhysicalObjectContainerName Name,
        PhysicalObjectContainer? Parent,
        IEnumerable<PhysicalObjectContainer> Children,
        IEnumerable<PhysicalObject> PhysicalObjects);
}
