using Object.Application.Contracts.Default;
using Object.Domain.Default;
using Object.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Object.Application.Default
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
            var response = new Response<List<MenuTree>>();

            List<MenuTree> result = new List<MenuTree>();

            var list0 = (from a in await menus.GetListAsync()
                         join b in await roleMenus.GetListAsync() on a.Id equals b.MenuId
                         join c in await userRoles.GetListAsync() on b.RoleId equals c.Id
                         join d in await users.GetListAsync() on c.UserId equals d.Id
                         where d.Name == userName && a.Level == 0
                         select a).ToList();

            for (int i = 0; i < list0.Count; i++)
            {
                var dto = ObjectMapper.Map<Menu, MenuTree>(list0[i]);

                dto.Children = new List<MenuTree>();

                var list1 = (from a in await menus.GetListAsync()
                             join b in await roleMenus.GetListAsync() on a.Id equals b.MenuId
                             join c in await userRoles.GetListAsync() on b.RoleId equals c.Id
                             join d in await users.GetListAsync() on c.UserId equals d.Id
                             where d.Name == userName && a.ParentId == list0[i].Id
                             select a).ToList();

                for (int j = 0; j < list1.Count; j++)
                {
                    var child = ObjectMapper.Map<Menu, MenuTree>(list1[j]);

                    dto.Children.Add(child);
                }

                result.Add(dto);
            }

            response.status = 200;
            response.msg = "加载成功";
            response.data = result;

            return response;
        }
    }
}