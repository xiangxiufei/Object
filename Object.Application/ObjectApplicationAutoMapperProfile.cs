using AutoMapper;
using Object.Application.Contracts.DTO;
using Object.Domain.Smkt;

namespace Object.Application
{
    public class ObjectApplicationAutoMapperProfile : Profile
    {
        public ObjectApplicationAutoMapperProfile()
        {
            CreateMap<Info107, LoginDto>()
               .ForMember(dest => dest.Token, opt => opt.Ignore());

            CreateMap<Info050, CompDto>();
            //CreateMap<Info107, UserRequest>()
            //   .ForMember(dest => dest.Account, opt => opt.MapFrom(src => src.Rydm))
            //   .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Kl));
        }
    }
}