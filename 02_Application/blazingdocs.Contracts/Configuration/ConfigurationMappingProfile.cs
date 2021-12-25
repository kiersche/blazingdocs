using AutoMapper;

namespace blazingdocs.Contracts
{
    public class ConfigurationMappingProfile : Profile
    {
        public ConfigurationMappingProfile()
        {
            CreateMap<Domain.StorageRootPath, string>().ConvertUsing(srp => srp.Value);
            CreateMap<string, Domain.StorageRootPath>().ConvertUsing(srp => new Domain.StorageRootPath(srp));
            CreateMap<Domain.Configuration, ConfigurationContract>().ReverseMap();
        }
    }
}
