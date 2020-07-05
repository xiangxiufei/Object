using Object.Domain.Object;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Object.EntityFrameworkCore.Object
{
    public class RoleMenuRepository : EfCoreRepository<ObjectDbContext, RoleMenu>, IRoleMenuRepository
    {
        public RoleMenuRepository(IDbContextProvider<ObjectDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}