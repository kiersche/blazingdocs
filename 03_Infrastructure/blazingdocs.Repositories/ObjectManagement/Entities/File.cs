namespace blazingdocs.core.Model
{
    public class File
    {
        public int FileId { get; set; }
        public string RelativePath { get; set; } = null!;
        public string? Description { get; set; }
        public string OriginalFilename { get; set; } = null!;

        public int? VirtualObjectId { get; set; }
        public VirtualObject? VirtualObject { get; set; }
    }
}
