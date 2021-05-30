using blazingdocs.Domain.VirtualObjects;

namespace blazingdocs.Domain.Files
{
    public record File(
        FileId? FileId,
        FullPath FullPath,
        FileDescription? Description,
        VirtualObjectId VirtualObjectId,
        VirtualObject VirtualObject);
}
