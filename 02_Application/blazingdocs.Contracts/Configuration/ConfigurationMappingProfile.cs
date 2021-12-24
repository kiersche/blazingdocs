using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazingdocs.Contracts
{
    public class ConfigurationMappingProfile : Profile
    {
        public ConfigurationMappingProfile()
        {
            CreateMap<Domain.StorageRootPath, string>().ConvertUsing(srp => srp.Value);
            CreateMap<Domain.Configuration, ConfigurationContract>();
        }
    }
}
