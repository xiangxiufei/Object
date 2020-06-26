using Object.Application.Contracts.School;
using Object.Domain.School;
using System.Threading.Tasks;

namespace Object.Application.School
{
    public class StudentService : ObjectAppService, IStudentService
    {
        private readonly IStudentRepository students;

        public StudentService(IStudentRepository students)
        {
            this.students = students;
        }

        public async Task<string> Insert(StudentDto dto)
        {
            var entity = ObjectMapper.Map<StudentDto, Student>(dto);

            await students.InsertAsync(entity);

            return "true";
        }

        public async Task<string> Delete(int id)
        {
            await students.DeleteAsync(t => t.Sid == id);

            return "true";
        }

        public async Task<string> Update(StudentDto dto)
        {
            var entity = ObjectMapper.Map<StudentDto, Student>(dto);

            await students.UpdateAsync(entity);

            return "true";
        }

        public async Task<string> GetEntity(int id)
        {
            var entity = await students.GetAsync(t => t.Sid == id);
            return entity.ToString();
        }
    }
}