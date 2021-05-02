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

        public ICollection<Property> Properties { get; set; }
        public ICollection<File> Files { get; set; }

        public ICollection<Category> Categorys { get; set; }
    }
}
