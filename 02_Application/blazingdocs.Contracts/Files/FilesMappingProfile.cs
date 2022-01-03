using AutoMapper;

namespace blazingdocs.Contracts.Files
{
    public class FilesMappingProfile : Profile
    {
        public FilesMappingProfile()
        {
            CreateMap<Domain.FileId, int>().ConvertUsing(fId => fId.Value);
            CreateMap<int, Domain.FileId>().ConvertUsing(fId => new Domain.FileId(fId));
            CreateMap<Domain.OriginalFilename, string>().ConvertUsing(origFn => origFn.Value);
            CreateMap<string, Domain.OriginalFilename>().ConvertUsing(origFn => new Domain.OriginalFilename(origFn));
            CreateMap<Domain.FileDescription, string>().ConvertUsing(fDesc => fDesc.Value);
            CreateMap<string, Domain.FileDescription>().ConvertUsing(fDesc => new Domain.FileDescription(fDesc));

            CreateMap<Domain.File, FileContract>().ReverseMap();
            CreateMap<Domain.StoredFile, StoredFileContract>();
        }
    }
}
