﻿using blazingdocs.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace blazingdocs.UI.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigurationController : Controller
    {
        private readonly IOptionsMonitor<ConfigurationContract> options;

        public ConfigurationController(
            IOptionsMonitor<ConfigurationContract> options)
        {
            this.options = options;
        }

        [HttpGet]
        public ConfigurationContract Get()
        {
            return options.CurrentValue;
        }
    }
}
