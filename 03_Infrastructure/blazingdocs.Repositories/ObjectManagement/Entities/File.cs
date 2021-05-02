using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class File
    {
        public int FileId { get; set; }
        public string FullPath { get; set; }
        public string Description { get; set; }

        public int ObjectId { get; set; }
        public Object Object { get; set; }
    }
}
