using System.IO;
using System.Threading.Tasks;

namespace blazingdocs.Domain;

public interface IFileApplicationService
{
    Task<StoredFile> StoreFileAsync(File fileDescriptor, Stream fileContent);
}
