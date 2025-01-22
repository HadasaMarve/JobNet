using AutoMapper;
using JobNet.Core.Entities;
using JobNet.Models;

namespace JobNet
{
    public class MappingPostModel:Profile
    {
        public MappingPostModel()
        {
            CreateMap<Employer, EmployerPostModel>().ReverseMap();
            CreateMap<Job, JobPostModel>().ReverseMap();
            CreateMap<Request, RequestPostModel>().ReverseMap();
            CreateMap<Subscription, SubscriptionPostModel>().ReverseMap();
            CreateMap<User, UserPostModel>().ReverseMap();
        }
    }
}
