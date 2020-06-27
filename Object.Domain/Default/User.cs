using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Object.Domain.Default
{
    public interface IUserRepository : IRepository<User>
    {
    }

    public class User : Entity
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { Id };
        }
    }
}