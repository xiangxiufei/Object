using AutoMapper;
using Object.Application.Contracts.Object;
using Object.Domain.Object;
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

            CreateMap<User, UserDto>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(s => s.Status == "0" ? false : true));

            //CreateMap<UserDto, User>()
            // .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.UserName))
            // .ForMember(dest => dest.Password, opt => opt.Ignore());
        }
    }
}