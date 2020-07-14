using Object.Domain.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Object.Application.Contracts.Object
{
    public interface IRoleService
    {
        Task<Response<List<RoleTree>>> GetRoleTree();

        Task<Response<string>> CreateRole(RoleDto dto);

        Task<Response<RoleIdDto>> GetRole(int id);

        Task<Response<string>> UpdateRole(int id, RoleDto dto);

        Task<Response<string>> DeleteRole(int id);

        Task<Response<RoleTree>> DeleteRoleMenus(int roleId, int menuId);

        Task<Response<string>> CreateRoleMenu(int roleId, string menuIds);
    }

    public class RoleIdDto
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }
    }

    public class RoleDto
    {
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }
    }

    public class RoleTree
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }
        public List<MenuTree> Children { get; set; }
    }
}