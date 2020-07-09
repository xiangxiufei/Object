using Object.Application.Contracts.Object;
using Object.Domain.Object;
using Object.Domain.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Object.Application.Object
{
    public class RoleService : ObjectAppService, IRoleService
    {
        private readonly IUserRepository users;
        private readonly IRoleRepository roles;
        private readonly IUserRoleRepository userRoles;
        private readonly IMenuRepository menus;
        private readonly IRoleMenuRepository roleMenus;

        public RoleService(IUserRepository users, IRoleRepository roles, IUserRoleRepository userRoles, IMenuRepository menus, IRoleMenuRepository roleMenus)
        {
            this.users = users;
            this.roles = roles;
            this.userRoles = userRoles;
            this.menus = menus;
            this.roleMenus = roleMenus;
        }

        public async Task<Response<List<RoleTree>>> GetRoleTree()
        {
            var result = new Response<List<RoleTree>>();

            var role = (from a in await roles.GetListAsync()
                        join b in await userRoles.GetListAsync() on a.Id equals b.RoleId
                        join c in await users.GetListAsync() on b.UserId equals c.Id
                        select a).ToList();

            var list = ObjectMapper.Map<List<Role>, List<RoleTree>>(role);

            foreach (var item in list)
            {
                item.Children = await GetMenuTree(item.Id, 0);
            }

            result.Success(list);

            return result;
        }

        public async Task<List<MenuTree>> GetMenuTree(int roleId, int parentID)
        {
            List<MenuTree> result = new List<MenuTree>();
            List<Menu> list = (from a in await menus.GetListAsync()
                               join b in await roleMenus.GetListAsync() on a.Id equals b.MenuId
                               join c in await userRoles.GetListAsync() on b.RoleId equals c.Id
                               where c.RoleId == roleId && a.ParentId == parentID
                               orderby a.Sort
                               select a).ToList();

            foreach (var menu in list)
            {
                var dto = ObjectMapper.Map<Menu, MenuTree>(menu);
                dto.Children = await GetMenuTree(roleId, menu.Id);

                result.Add(dto);
            }

            return result;
        }
    }
}