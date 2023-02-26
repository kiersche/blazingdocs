using blazingdocs.Contracts;
using blazingdocs.Contracts.Files;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace blazingdocs.UI.Server.Controllers;

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

    //[HttpPost]
    //public async Task<ActionResult<List<FileUploadResultContract>>> PostFile([FromForm] IEnumerable<IFormFile> files)
    //{

    //}
}
