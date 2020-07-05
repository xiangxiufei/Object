using Object.Domain.Object;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Object.EntityFrameworkCore.Object
{
    public class UserRepository : EfCoreRepository<ObjectDbContext, User>, IUserRepository
    {
        public UserRepository(IDbContextProvider<ObjectDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}