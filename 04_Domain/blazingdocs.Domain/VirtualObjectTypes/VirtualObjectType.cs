using blazingdocs.Domain.Propertys;
using blazingdocs.Domain.VirtualObjects;
using System.Collections.Generic;

namespace blazingdocs.Domain.VirtualObjectTypes
{
    public record VirtualObjectType(
        VirtualObjectTypeId VirtualObjectTypeId,
        VirtualObjectTypeName Name,

        ICollection<PropertyField> PropertyFields,

        VirtualObjectType? Parent,
        IEnumerable<VirtualObjectType> Children,
        IEnumerable<VirtualObject> Objects);
}
