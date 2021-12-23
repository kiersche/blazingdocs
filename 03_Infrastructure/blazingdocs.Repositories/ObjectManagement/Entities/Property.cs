namespace blazingdocs.core.Model
{
    public class Property
    {
        public int PropertyId { get; set; }

        public int PropertyFieldId { get; set; }
        public PropertyField PropertyField { get; set; } = null!;

        public int? PropertyValueId { get; set; }
        public PropertyValue? PropertyValue { get; set; }

        public int VirtualObjectId { get; set; }
        public VirtualObject VirtualObject { get; set; } = null!;
    }
}
