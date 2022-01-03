namespace blazingdocs.Domain
{
    public record StoredFile(
        FileId? FileId,
        FullPath FullPath,
        OriginalFilename OriginalFilename,
        FileDescription? Description) : File(OriginalFilename, Description);
}
