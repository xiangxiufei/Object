using System.Collections.Generic;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Object.Domain.Object
{
    public interface IUserRepository : IRepository<User>
    {
    }

    public class User : Entity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public string Status { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { Id };
        }
    }
}