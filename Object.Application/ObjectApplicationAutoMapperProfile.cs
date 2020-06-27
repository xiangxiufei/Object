using AutoMapper;
using Object.Application.Contracts.Default;
using Object.Domain.Default;

namespace Object.Application
{
    public class ObjectApplicationAutoMapperProfile : Profile
    {
        public ObjectApplicationAutoMapperProfile()
        {
            CreateMap<User, UserResponse>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Token, opt => opt.Ignore()); ;
        }
    }
}