using System.Threading.Tasks;

namespace blazingdocs.Domain
{
    public interface IConfigurationApplicationService
    {
        Task<Configuration> GetConfigurationAsync();
    }
}
