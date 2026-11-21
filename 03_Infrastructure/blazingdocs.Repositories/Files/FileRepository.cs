using blazingdocs.Domain;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace blazingdocs.Repositories.Files;

internal class FileRepository : IFileRepository
{
    private readonly FileStorageConfiguration storage;
    private readonly IDateTimeProvider dateTimeProvider;

    public FileRepository(IOptions<FileStorageConfiguration> options, IDateTimeProvider dateTimeProvider)
    {
        storage = options.Value;
        this.dateTimeProvider = dateTimeProvider;
    }

    public async Task<RelativePath> StoreFile(Stream file)
    {
        string directory = dateTimeProvider.Today.ToString("yyyy'/'MM'/'dd", CultureInfo.InvariantCulture);
        RelativePath relativePath;
        string destination;
        do
        {
            relativePath = new RelativePath($"{directory}/{Path.GetRandomFileName()}");
            destination = storage.Resolve(relativePath);
        } while (System.IO.File.Exists(destination));

        Directory.CreateDirectory(Path.GetDirectoryName(destination)!);
        await using var output = new FileStream(destination, FileMode.CreateNew);
        await file.CopyToAsync(output);
        return relativePath;
    }
}
