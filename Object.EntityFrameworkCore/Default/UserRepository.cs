using Object.Domain.Default;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Object.EntityFrameworkCore.Default
{
    public class UserRepository : EfCoreRepository<ObjectDbContext, User>, IUserRepository
    {
        public UserRepository(IDbContextProvider<ObjectDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}