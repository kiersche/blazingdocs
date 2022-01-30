namespace blazingdocs.Domain
{
    public record StoredFile(
        FileId FileId,
        RelativePath RelativePath,
        OriginalFilename OriginalFilename,
        FileDescription? Description) : File(OriginalFilename, Description);
}
