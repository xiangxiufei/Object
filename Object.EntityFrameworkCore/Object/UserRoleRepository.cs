using Object.Domain.Object;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Object.EntityFrameworkCore.Object
{
    public class UserRoleRepository : EfCoreRepository<ObjectDbContext, UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(IDbContextProvider<ObjectDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}