using blazingdocs.Domain;
using Microsoft.AspNetCore.Http;
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

    public async Task<StoredFile> StoreFileAsync(File fileDescriptor, IFormFile fileContent)
    {
        RelativePath relativeStoredPath = await fileRepository.StoreFile(fileContent);

        StoredFileFactory storageCandidate = new(relativeStoredPath, fileDescriptor.OriginalFilename, fileDescriptor.Description);
        StoredFile storedFile = await objectRepository.SaveFileAsync(storageCandidate);

        return storedFile;
    }
}
