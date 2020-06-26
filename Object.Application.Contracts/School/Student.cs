using System.Threading.Tasks;

namespace Object.Application.Contracts.School
{
    public interface IStudentService
    {
        Task<string> Insert(StudentDto dto);

        Task<string> Delete(int id);

        Task<string> Update(StudentDto dto);

        Task<string> GetEntity(int id);
    }

    public class StudentDto
    {
        public int Sid { get; set; }

        public string Sname { get; set; }

        public int Sage { get; set; }

        public string Ssex { get; set; }
    }
}