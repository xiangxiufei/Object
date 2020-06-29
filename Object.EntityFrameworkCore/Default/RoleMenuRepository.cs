using Object.Domain.Default;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Object.EntityFrameworkCore.Default
{
    public class RoleMenuRepository : EfCoreRepository<ObjectDbContext, RoleMenu>, IRoleMenuRepository
    {
        public RoleMenuRepository(IDbContextProvider<ObjectDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}