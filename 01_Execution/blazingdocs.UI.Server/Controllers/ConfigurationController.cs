using AutoMapper;
using blazingdocs.Contracts;
using blazingdocs.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace blazingdocs.UI.Server.Controllers
{
    [ApiController]
    public class ConfigurationController : Controller
    {
        private readonly IConfigurationApplicationService configurationApplicationService;
        private readonly IMapper mapper;

        public ConfigurationController(
            IConfigurationApplicationService configurationApplicationService,
            IMapper mapper)
        {
            this.configurationApplicationService = configurationApplicationService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ConfigurationContract> Get()
        {
            Configuration configuration = await configurationApplicationService.GetConfigurationAsync();
            return mapper.Map<ConfigurationContract>(configuration);
        }
    }
}
