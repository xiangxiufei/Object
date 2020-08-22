using AutoMapper;
using Object.Domain.Smkt;
using static Object.Domain.Shared.Jwt;

namespace Object.Application
{
    public class ObjectApplicationAutoMapperProfile : Profile
    {
        public ObjectApplicationAutoMapperProfile()
        {
            CreateMap<Info107, UserResponse>()
               .ForMember(dest => dest.Token, opt => opt.Ignore());

            //CreateMap<Info107, UserRequest>()
            //   .ForMember(dest => dest.Account, opt => opt.MapFrom(src => src.Rydm))
            //   .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Kl));
        }
    }
}