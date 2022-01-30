using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace blazingdocs.Domain;

public interface IFileApplicationService
{
    Task<StoredFile> StoreFileAsync(File fileDescriptor, IFormFile fileContent);
}
