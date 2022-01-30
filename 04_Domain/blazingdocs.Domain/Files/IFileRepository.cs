using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace blazingdocs.Domain;

public interface IFileRepository
{
    Task<RelativePath> StoreFile(IFormFile file);
}
