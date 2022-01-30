using AutoMapper;
using blazingdocs.core.Model;

namespace blazingdocs.Repositories.ObjectManagement
{
    public class ObjectMappingProfile : Profile
    {
        public ObjectMappingProfile()
        {
            CreateMap<Domain.File, File>()
                .ForMember(file => file.FileId, opt => opt.Ignore())
                .ForMember(file => file.RelativePath, opt => opt.Ignore())
                .ForMember(file => file.VirtualObjectId, opt => opt.Ignore())
                .ForMember(file => file.VirtualObject, opt => opt.Ignore());


        }
    }
}
