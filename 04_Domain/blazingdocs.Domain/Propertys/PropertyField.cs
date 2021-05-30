namespace blazingdocs.Domain.Propertys
{
    public enum PropertyType { Text, Number, Float, Money, Date, DateTime }

    public record PropertyField(
        PropertyFieldId PropertyFieldId,
        PropertyFieldName Name,
        PropertyType PropertyType);
}
