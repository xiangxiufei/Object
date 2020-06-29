using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Object.Domain.Default
{
    public interface IUserRoleRepository : IRepository<UserRole>
    {
    }

    public class UserRole : Entity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { Id };
        }
    }
}