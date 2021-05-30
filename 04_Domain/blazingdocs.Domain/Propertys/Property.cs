using blazingdocs.Domain.VirtualObjects;

namespace blazingdocs.Domain.Propertys
{
    public record Property(
        PropertyId PropertyId,
        PropertyField PropertyField,
        PropertyValue? PropertyValue,
        VirtualObject VirtualObject);
}
