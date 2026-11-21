using System.IO;
using System.Threading.Tasks;

namespace blazingdocs.Domain;

public interface IFileRepository
{
    Task<RelativePath> StoreFile(Stream file);
}
