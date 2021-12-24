using AutoMapper;
using blazingdocs.Domain;

namespace blazingdocs.Infrastructure.Configuration
{
    public class ConfigurationMappingProfile : Profile
    {
        public ConfigurationMappingProfile()
        {
            CreateMap<string, StorageRootPath>().ConvertUsing(s => new StorageRootPath(s));
            CreateMap<Repositories.Configuration, Domain.Configuration>();
        }
    }
}
