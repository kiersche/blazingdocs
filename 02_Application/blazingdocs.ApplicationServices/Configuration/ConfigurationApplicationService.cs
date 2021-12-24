using blazingdocs.Domain;
using System.Threading.Tasks;

namespace blazingdocs.ApplicationServices
{
    internal class ConfigurationApplicationService : IConfigurationApplicationService
    {
        private readonly IConfigurationRepository configurationRepository;

        public ConfigurationApplicationService(IConfigurationRepository configurationRepository)
        {
            this.configurationRepository = configurationRepository;
        }

        public Task<Configuration> GetConfigurationAsync() => configurationRepository.GetConfigurationAsync();
    }
}
