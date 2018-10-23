using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public enum PropertyType { Text, Number, Date, Time, DateTime }

    public class PropertyField
    {
        public int PropertyFieldId { get; set; }
        public string Name { get; set; }
        public PropertyType PropertyType { get; set; }
    }
}
