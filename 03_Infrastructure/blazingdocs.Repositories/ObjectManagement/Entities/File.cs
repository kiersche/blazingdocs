namespace blazingdocs.core.Model
{
    public class File
    {
        public int FileId { get; set; }
        public string FullPath { get; set; }
        public string Description { get; set; }

        public int VirtualObjectId { get; set; }
        public VirtualObject VirtualObject { get; set; }
    }
}
