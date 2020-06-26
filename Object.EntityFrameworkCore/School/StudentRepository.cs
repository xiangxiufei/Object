using Object.Domain.School;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Object.EntityFrameworkCore.School
{
    public class StudentRepository : EfCoreRepository<ObjectDbContext, Student>, IStudentRepository
    {
        public StudentRepository(IDbContextProvider<ObjectDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}