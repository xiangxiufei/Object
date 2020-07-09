using Object.Domain.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Object.Application.Contracts.Object
{
    public interface IRoleService
    {
        Task<Response<List<RoleTree>>> GetRoleTree();
    }

    public class RoleTree
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }
        public List<MenuTree> Children { get; set; }
    }
}