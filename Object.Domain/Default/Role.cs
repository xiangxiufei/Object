using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Object.Domain.Default
{
    public interface IRoleRepository : IRepository<Role>
    {
    }

    public class Role : Entity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Sort { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { Id };
        }
    }
}