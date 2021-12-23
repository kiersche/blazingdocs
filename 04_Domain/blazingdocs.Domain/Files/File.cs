namespace blazingdocs.Domain.Files
{
    public record File(
        FileId? FileId,
        FullPath FullPath,
        OriginalFilename OriginalFilename,
        FileDescription? Description);
}
