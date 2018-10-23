using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class PropertyValue
    {
        public int PropertyValueId { get; set; }
        public string Value { get; set; }

        public int PropertyFieldId { get; set; }
        public PropertyField PropertyField { get; set; }
    }
}
