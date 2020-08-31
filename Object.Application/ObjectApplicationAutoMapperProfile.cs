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

            CreateMap<Info702, PaymentMethod>();

            CreateMap<Jyhz, Smkt140>()
                .ForMember(dest => dest.Hybh, opt => opt.Ignore())
                .ForMember(dest => dest.Zkje, opt => opt.Ignore())
                .ForMember(dest => dest.Yhje, opt => opt.Ignore())
                .ForMember(dest => dest.Xj, opt => opt.Ignore())
                .ForMember(dest => dest.Zp, opt => opt.Ignore())
                .ForMember(dest => dest.Xyk, opt => opt.Ignore())
                .ForMember(dest => dest.Hyk, opt => opt.Ignore())
                .ForMember(dest => dest.Yhxyk, opt => opt.Ignore())
                .ForMember(dest => dest.Yhxyklx, opt => opt.Ignore())
                .ForMember(dest => dest.Yyydm, opt => opt.Ignore())
                .ForMember(dest => dest.Zlje, opt => opt.Ignore())
                .ForMember(dest => dest.Je1, opt => opt.Ignore())
                .ForMember(dest => dest.Je2, opt => opt.Ignore())
                .ForMember(dest => dest.Je3, opt => opt.Ignore())
                .ForMember(dest => dest.Gnqje, opt => opt.Ignore())
                .ForMember(dest => dest.Clsj, opt => opt.Ignore())
                .ForMember(dest => dest.Zlczje, opt => opt.Ignore())
                .ForMember(dest => dest.YhxykNo, opt => opt.Ignore())
                .ForMember(dest => dest.Zlyh, opt => opt.Ignore())
                .ForMember(dest => dest.Hyyh, opt => opt.Ignore())
                .ForMember(dest => dest.Fkfs1, opt => opt.Ignore())
                .ForMember(dest => dest.Fkfs2, opt => opt.Ignore())
                .ForMember(dest => dest.Fkfs3, opt => opt.Ignore())
                .ForMember(dest => dest.Fkfs4, opt => opt.Ignore())
                .ForMember(dest => dest.Fkfs5, opt => opt.Ignore())
                .ForMember(dest => dest.Fkfs6, opt => opt.Ignore())
                .ForMember(dest => dest.Fkfs7, opt => opt.Ignore())
                .ForMember(dest => dest.Fkfs8, opt => opt.Ignore())
                .ForMember(dest => dest.Lmkye, opt => opt.Ignore());

            CreateMap<Jysp, Smkt141>()
                .ForMember(dest => dest.Zkje, opt => opt.Ignore())
                .ForMember(dest => dest.Yhje, opt => opt.Ignore())
                .ForMember(dest => dest.Xsph, opt => opt.Ignore())
                .ForMember(dest => dest.Jfbl, opt => opt.Ignore())
                .ForMember(dest => dest.Zlyh, opt => opt.Ignore())
                .ForMember(dest => dest.Hyyh, opt => opt.Ignore())
                .ForMember(dest => dest.Cxbz, opt => opt.Ignore())
                .ForMember(dest => dest.Yyydm, opt => opt.Ignore())
                .ForMember(dest => dest.Abcx, opt => opt.Ignore())
                .ForMember(dest => dest.Bsyh, opt => opt.Ignore())
                .ForMember(dest => dest.Mzyh, opt => opt.Ignore())
                .ForMember(dest => dest.Mmyh, opt => opt.Ignore())
                .ForMember(dest => dest.CompId, opt => opt.Ignore());

            CreateMap<Jyfs, Smkt142>()
                .ForMember(dest => dest.CompId, opt => opt.Ignore());

            //   .ForMember(dest => dest.Account, opt => opt.MapFrom(src => src.Rydm))
            //   .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.Kl));
        }
    }
}