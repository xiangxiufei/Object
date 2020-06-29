﻿using Object.Domain.Default;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Object.EntityFrameworkCore.Default
{
    public class MenuRepository : EfCoreRepository<ObjectDbContext, Menu>, IMenuRepository
    {
        public MenuRepository(IDbContextProvider<ObjectDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}