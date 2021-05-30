using blazingdocs.Domain.Categories;
using blazingdocs.Domain.Files;
using blazingdocs.Domain.PhysicalObjects;
using blazingdocs.Domain.Propertys;
using blazingdocs.Domain.VirtualObjectTypes;
using System.Collections.Generic;

namespace blazingdocs.Domain.VirtualObjects
{
    public record VirtualObject(
        VirtualObjectId VirtualObjectId,
        VirtualObjectCreatedTime Created,
        VirtualObjectModifiedTime Modified,

        PhysicalObject? PhysicalObject,
        VirtualObjectType? VirtualObjectType,
        IEnumerable<Property> Properties,
        IEnumerable<File> Files,
        IEnumerable<Category> Categories);
}
