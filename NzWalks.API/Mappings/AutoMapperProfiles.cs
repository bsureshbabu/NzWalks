using AutoMapper;
using NzWalks.API.Models.Domain;
using NzWalks.API.Models.DTOs;

namespace NzWalks.API.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //reverse map is used to map from DTO to Domain and vice vers
            CreateMap<Regions, RegionDto>().ReverseMap();
            //CreateMap<AddRegionDto, Regions>().ReverseMap();
            CreateMap<Walks,AddWalkerDto>().ReverseMap();
            CreateMap<Difficulties, DifficultyDto>().ReverseMap();
        }
    }
}
