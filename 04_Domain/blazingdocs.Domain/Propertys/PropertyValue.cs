using System;

namespace blazingdocs.Domain.Propertys
{
    public class PropertyValue
    {
        public int PropertyValueId { get; set; }

        public Property Property { get; set; }

        //PropertyType { Text, Number, Float, Money, Date, DateTime }
        public string TextValue { get; set; }
        public int? NumberValue { get; set; }
        public float? FloatValue { get; set; }
        public decimal? MoneyValue { get; set; }
        public DateTime? DateValue { get; set; }
        public DateTime? DateTimeValue { get; set; }
    }
}
