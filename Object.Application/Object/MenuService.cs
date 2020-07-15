using Object.Application.Contracts.Object;
using Object.Domain.Object;
using Object.Domain.Shared;
using Object.Domain.Shared.Extensions;
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

        public async Task<string> GetMenu(string type)
        {
            string result = string.Empty;

            if (type.Equals("list"))
            {
                var list = new Response<List<MenuList>>();

                var menuList = (from a in await menus.GetListAsync()
                                orderby a.Sort
                                select a).ToList();

                var dto = ObjectMapper.Map<List<Menu>, List<MenuList>>(menuList);

                list.Success(dto);

                result = list.ToJson();
            }
            else if (type.Equals("tree"))
            {
                var tree = new Response<List<MenuTree>>()
                {
                    status = 200,
                    msg = "加载成功",
                    data = await GetMenuTree(0)
                };

                result = tree.ToJson();
            }

            return result;
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

        public async Task<List<MenuTree>> GetMenuTree(string userName, int parentID)
        {
            List<MenuTree> result = new List<MenuTree>();

            var list = (from a in menus
                        join b in roleMenus on a.Id equals b.MenuId
                        join c in userRoles on b.RoleId equals c.RoleId
                        join d in users on c.UserId equals d.Id
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

        public async Task<List<MenuTree>> GetMenuTree(int parentID)
        {
            List<MenuTree> result = new List<MenuTree>();

            var list = (from a in menus
                        where a.ParentId == parentID
                        orderby a.Sort
                        select a).ToList();

            foreach (var menu in list)
            {
                var dto = ObjectMapper.Map<Menu, MenuTree>(menu);
                dto.Children = await GetMenuTree(menu.Id);

                result.Add(dto);
            }

            return result;
        }
    }
}