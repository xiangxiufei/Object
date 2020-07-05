using Object.Application.Contracts.Object;
using Object.Domain.Object;
using Object.Domain.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Object.Application.Object
{
    public class MenuService : ObjectAppService, IMenuService
    {
        private readonly IUserRepository users;
        private readonly IUserRoleRepository userRoles;
        private readonly IMenuRepository menus;
        private readonly IRoleMenuRepository roleMenus;

        public MenuService(IUserRepository users, IUserRoleRepository userRoles, IMenuRepository menus, IRoleMenuRepository roleMenus)
        {
            this.users = users;
            this.userRoles = userRoles;
            this.menus = menus;
            this.roleMenus = roleMenus;
        }

        public async Task<Response<List<MenuTree>>> GetMenuTree(string userName)
        {
            return new Response<List<MenuTree>>()
            {
                status = 200,
                msg = "加载成功",
                data = await GetMenuTree(userName, 0)
            };
        }

        private async Task<List<MenuTree>> GetMenuTree(string userName, int parentID)
        {
            List<MenuTree> result = new List<MenuTree>();
            List<Menu> list = (from a in await menus.GetListAsync()
                               join b in await roleMenus.GetListAsync() on a.Id equals b.MenuId
                               join c in await userRoles.GetListAsync() on b.RoleId equals c.Id
                               join d in await users.GetListAsync() on c.UserId equals d.Id
                               where d.Name == userName && a.ParentId == parentID
                               orderby a.Sort
                               select a).ToList();

            foreach (var menu in list)
            {
                var dto = ObjectMapper.Map<Menu, MenuTree>(menu);
                dto.Children = await GetMenuTree(userName, menu.Id);

                result.Add(dto);
            }

            return result;
        }
    }
}