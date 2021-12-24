using AutoMapper;
using blazingdocs.Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace blazingdocs.Repositories
{
    internal class ConfigurationRepository : IConfigurationRepository
    {
        private readonly ConfigurationDbContext dbContext;
        private readonly IMapper mapper;

        public ConfigurationRepository(ConfigurationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<Domain.Configuration> GetConfigurationAsync()
        {
            Configuration config = await dbContext.Configurations.FirstAsync();

            return mapper.Map<Domain.Configuration>(config);
        }
    }
}
