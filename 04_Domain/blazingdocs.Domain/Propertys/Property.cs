using blazingdocs.Domain.VirtualObjects;

namespace blazingdocs.Domain.Propertys
{
    public class Property
    {
        public int PropertyId { get; set; }

        public int PropertyFieldId { get; set; }
        public PropertyField PropertyField { get; set; }

        public int? PropertyValueId { get; set; }
        public PropertyValue PropertyValue { get; set; }

        public int ObjectId { get; set; }
        public VirtualObject Object { get; set; }
    }
}
