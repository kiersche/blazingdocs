using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace blazingdocs.core.Model
{
    public class PropertyValue
    {
        public int PropertyValueId { get; set; }

        public Property Property { get; set; } = null!;

        //PropertyType { Text, Number, Float, Money, Date, DateTime }
        public string? TextValue { get; set; }

        public int? NumberValue { get; set; }

        public float? FloatValue { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal? MoneyValue { get; set; }

        public DateTime? DateValue { get; set; }

        public DateTime? DateTimeValue { get; set; }
    }
}
