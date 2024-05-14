using AutoMapper;
using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Domain;

namespace Freelancer.Backend.Business.Mapping
{
    public class BusinessMappingProfile : Profile
    {
        public BusinessMappingProfile()
        {
            CreateMap<User,UserDTO>().ReverseMap();
            CreateMap<Role,RoleDto>().ReverseMap();
            CreateMap<Photo,PhotoDto>().ReverseMap();
        }
    }
}
