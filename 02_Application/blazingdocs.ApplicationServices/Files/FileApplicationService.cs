using System.IO;
using blazingdocs.Domain;
using System.Threading.Tasks;

namespace blazingdocs.ApplicationServices.Files;

internal class FileApplicationService : IFileApplicationService
{
    private readonly IObjectRepository objectRepository;
    private readonly IFileRepository fileRepository;

    public FileApplicationService(IObjectRepository objectRepository, IFileRepository fileRepository)
    {
        this.objectRepository = objectRepository;
        this.fileRepository = fileRepository;
    }

    public async Task<StoredFile> StoreFileAsync(Domain.File fileDescriptor, Stream fileContent)
    {
        RelativePath relativeStoredPath = await fileRepository.StoreFile(fileContent);

        StoredFileFactory storageCandidate = new(relativeStoredPath, fileDescriptor.OriginalFilename, fileDescriptor.Description);
        StoredFile storedFile = await objectRepository.SaveFileAsync(storageCandidate);

        return storedFile;
    }
}
