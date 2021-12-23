namespace blazingdocs.core.Model
{
    public enum PropertyType { Text, Number, Float, Money, Date, DateTime }

    public class PropertyField
    {
        public int PropertyFieldId { get; set; }
        public string Name { get; set; } = null!;
        public PropertyType PropertyType { get; set; }
    }
}
