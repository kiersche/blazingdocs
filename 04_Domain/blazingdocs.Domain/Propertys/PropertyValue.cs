using System;

namespace blazingdocs.Domain.Propertys
{
    public record PropertyValue(
        PropertyValueId PropertyValueId,
        Property Property,
        //PropertyType { Text, Number, Float, Money, Date, DateTime }
        string? TextValue,
        int? NumberValue,
        float? FloatValue,
        decimal? MoneyValue,
        DateTime? DateValue,
        DateTime? DateTimeValue);
}
