namespace blazingdocs.Domain;

public record StoredFileFactory(
    RelativePath RelativePath,
    OriginalFilename OriginalFilename,
    FileDescription? Description)
{
    public StoredFile ToStoredFile(FileId fileId) => new StoredFile(fileId, RelativePath, OriginalFilename, Description);
}
