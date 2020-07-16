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

            CreateMap<User, UserDto>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(s => s.Status == "0" ? false : true))
                .ForMember(dest => dest.roleName, opt => opt.Ignore());

            CreateMap<CreateUserDto, User>()
                 .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.UserName))
                 .ForMember(dest => dest.Id, opt => opt.Ignore())
                 .ForMember(dest => dest.Status, opt => opt.Ignore());

            CreateMap<Menu, MenuTree>()
                .ForMember(dest => dest.AuthName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Path, opt => opt.MapFrom(src => src.Url))
                .ForMember(dest => dest.Children, opt => opt.Ignore());

            CreateMap<Menu, MenuList>()
                .ForMember(dest => dest.AuthName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Pid, opt => opt.MapFrom(src => src.ParentId))
                .ForMember(dest => dest.Path, opt => opt.MapFrom(src => src.Url));

            CreateMap<Role, RoleTree>()
                .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.RoleDesc, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Children, opt => opt.Ignore());

            CreateMap<RoleDto, Role>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.RoleName))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.RoleDesc))
                .ForMember(dest => dest.Sort, opt => opt.Ignore());

            CreateMap<Role, RoleDto>()
              .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Name))
              .ForMember(dest => dest.RoleDesc, opt => opt.MapFrom(src => src.Description));

            CreateMap<Role, RoleIdDto>()
             .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Name))
             .ForMember(dest => dest.RoleDesc, opt => opt.MapFrom(src => src.Description));
        }
    }
}