namespace blazingdocs.Contracts;

public static class ConfigurationMapping
{
    public static ConfigurationContract ToContract(this Domain.Configuration configuration) =>
        new() { StorageRootPath = configuration.StorageRootPath.Value };

    public static Domain.Configuration ToDomain(this ConfigurationContract contract) =>
        new(new Domain.StorageRootPath(contract.StorageRootPath));
}
