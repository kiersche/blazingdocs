namespace blazingdocs.Contracts.Files;

public record FileUploadResultContract(
    bool Successful,
    int? ErrorCode,
    string? ErrorMessage);
