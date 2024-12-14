using AutoMapper;
using JobNet.Core.DTOs;
using JobNet.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace JobNet.Core
{
    public class MappingProfile:profile
    {
        public MappingProfile()
        {
            CreateMap<Employer, EmployerDto>().ReverseMap();
            CreateMap<Job, JobDto>().ReverseMap();
            CreateMap<Request, RequestDto>().ReverseMap();
            CreateMap<Subscription, SubscriptionDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
