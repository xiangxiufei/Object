using AutoMapper;
using Object.Application.Contracts.Default;
using Object.Domain.Default;
using static Object.Domain.Shared.Jwt;

namespace Object.Application
{
    public class ObjectApplicationAutoMapperProfile : Profile
    {
        public ObjectApplicationAutoMapperProfile()
        {
            CreateMap<User, UserResponse>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Token, opt => opt.Ignore());

            CreateMap<Menu, MenuTree>()
                .ForMember(dest => dest.Path, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.Children, opt => opt.Ignore());
        }
    }
}