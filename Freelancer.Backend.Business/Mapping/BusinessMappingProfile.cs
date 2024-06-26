﻿using AutoMapper;
using Freelancer.Backend.Business.Dto;
using Freelancer.Backend.Domain;

namespace Freelancer.Backend.Business.Mapping
{
    public class BusinessMappingProfile : Profile
    {
        public BusinessMappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<UserPhoto, PhotoDto>().ReverseMap();
            CreateMap<JobDto, Job>().ReverseMap();
            CreateMap<RateDto, Rating>().ReverseMap();
        }
    }
}
