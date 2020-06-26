using AutoMapper;
using Object.Application.Contracts.School;
using Object.Domain.School;

namespace Object.Application
{
    public class ObjectApplicationAutoMapperProfile : Profile
    {
        public ObjectApplicationAutoMapperProfile()
        {
            CreateMap<Student, StudentDto>();

            CreateMap<StudentDto, Student>();
        }
    }
}