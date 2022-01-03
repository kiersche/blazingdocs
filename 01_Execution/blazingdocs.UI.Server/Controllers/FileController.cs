using blazingdocs.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace blazingdocs.UI.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : Controller
    {
        private readonly IOptionsMonitor<ConfigurationContract> options;

        public FileController(IOptionsMonitor<ConfigurationContract> options)
        {
            this.options = options;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("list-unassigned")]
        public 
    }
}
