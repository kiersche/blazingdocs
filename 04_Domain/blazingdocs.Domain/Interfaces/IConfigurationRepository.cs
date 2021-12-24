using System.Threading.Tasks;

namespace blazingdocs.Domain
{
    public interface IConfigurationRepository
    {
        Task<Configuration> GetConfigurationAsync();
    }
}
