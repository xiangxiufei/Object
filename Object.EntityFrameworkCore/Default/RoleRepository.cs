using Object.Domain.Default;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Object.EntityFrameworkCore.Default
{
    public class RoleRepository : EfCoreRepository<ObjectDbContext, Role>, IRoleRepository
    {
        public RoleRepository(IDbContextProvider<ObjectDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}