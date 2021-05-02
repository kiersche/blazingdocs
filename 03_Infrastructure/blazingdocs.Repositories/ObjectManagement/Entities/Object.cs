using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class Object
    {
        public int ObjectId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public PhysicalObject PhysicalObject { get; set; }

        public int? ObjectTypeId { get; set; }
        public ObjectType ObjectType { get; set; }

        public List<Property> Properties { get; set; }
        public List<File> Files { get; set; }

        public List<Category> Categorys { get; set; }
    }
}
