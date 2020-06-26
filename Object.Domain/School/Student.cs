using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Object.Domain.School
{
    public interface IStudentRepository : IRepository<Student>
    {
    }

    public class Student : Entity
    {
        public int Sid { get; set; }

        public string Sname { get; set; }

        public int Sage { get; set; }

        public string Ssex { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { Sid };
        }
    }
}