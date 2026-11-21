namespace blazingdocs.Contracts.Files;

public static class FileMapping
{
    public static FileContract ToContract(this Domain.File file) =>
        new() { OriginalFilename = file.OriginalFilename.Value, Description = file.Description?.Value };

    public static Domain.File ToDomain(this FileContract contract) =>
        new(new Domain.OriginalFilename(contract.OriginalFilename),
            contract.Description is null ? null : new Domain.FileDescription(contract.Description));

    public static StoredFileContract ToContract(this Domain.StoredFile file) =>
        new()
        {
            FileId = file.FileId.Value,
            OriginalFilename = file.OriginalFilename.Value,
            Description = file.Description?.Value
        };
}
