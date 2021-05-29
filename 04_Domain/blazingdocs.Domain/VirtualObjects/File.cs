namespace blazingdocs.Domain.VirtualObjects
{
    public class File
    {
        public int FileId { get; set; }
        public string FullPath { get; set; }
        public string Description { get; set; }

        public int ObjectId { get; set; }
        public VirtualObject Object { get; set; }
    }
}
