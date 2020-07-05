using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Object.Domain.Object
{
    public interface IRoleMenuRepository : IRepository<RoleMenu>
    {
    }

    public class RoleMenu : Entity
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int MenuId { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { Id };
        }
    }
}