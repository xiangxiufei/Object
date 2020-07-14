﻿using Object.Application.Contracts.Object;
using Object.Domain.Object;
using Object.Domain.Shared;
using Object.Domain.Shared.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Object.Application.Object
{
    public class RoleService : ObjectAppService, IRoleService
    {
        private readonly IRoleRepository roles;
        private readonly IUserRoleRepository userRoles;
        private readonly IMenuRepository menus;
        private readonly IRoleMenuRepository roleMenus;

        public RoleService(IRoleRepository roles, IUserRoleRepository userRoles, IMenuRepository menus, IRoleMenuRepository roleMenus)
        {
            this.roles = roles;
            this.userRoles = userRoles;
            this.menus = menus;
            this.roleMenus = roleMenus;
        }

        public async Task<Response<List<RoleTree>>> GetRoleTree()
        {
            var result = new Response<List<RoleTree>>();

            var role = await roles.GetListAsync();

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

            var list = (from a in menus
                        join b in roleMenus on a.Id equals b.MenuId
                        where b.RoleId == roleId && a.ParentId == parentID
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

        public async Task<Response<string>> CreateRole(RoleDto dto)
        {
            var result = new Response<string>();

            await roles.InsertAsync(ObjectMapper.Map<RoleDto, Role>(dto));

            result.msg = "角色创建成功！";

            return result;
        }

        public async Task<Response<RoleIdDto>> GetRole(int id)
        {
            var result = new Response<RoleIdDto>();

            var role = await roles.GetAsync(t => t.Id == id);

            result.Success(ObjectMapper.Map<Role, RoleIdDto>(role));

            return result;
        }

        public async Task<Response<string>> UpdateRole(int id, RoleDto dto)
        {
            var result = new Response<string>();

            var role = await roles.GetAsync(t => t.Id == id);
            role.Name = dto.RoleName;
            role.Description = dto.RoleDesc;

            await roles.UpdateAsync(role);

            result.msg = "更新角色信息成功！";

            return result;
        }

        public async Task<Response<string>> DeleteRole(int id)
        {
            var result = new Response<string>();

            var userRole = await userRoles.FindAsync(t => t.RoleId == id);

            if (userRole != null)
            {
                result.status = 500;
                result.msg = "该角色已绑定用户，无法删除！";
                return result;
            }

            var roleMenu = await roleMenus.FindAsync(t => t.RoleId == id);

            if (roleMenu != null)
            {
                result.status = 500;
                result.msg = "该角色已分配权限，无法删除！";
                return result;
            }

            await roles.DeleteAsync(t => t.Id == id);

            result.msg = "角色删除成功！";

            return result;
        }

        public async Task<Response<RoleTree>> DeleteRoleMenus(int roleId, int menuId)
        {
            var result = new Response<RoleTree>();

            await DeleteRoleMenu(roleId, menuId);

            var role = await roles.FindAsync(t => t.Id == roleId);

            result.data = ObjectMapper.Map<Role, RoleTree>(role);

            result.data.Children = await GetMenuTree(roleId, 0);

            result.msg = "角色权限删除成功！";

            return result;
        }

        public async Task DeleteRoleMenu(int roleId, int menuId)
        {
            await roleMenus.DeleteAsync(t => t.RoleId == roleId && t.MenuId == menuId, true);

            var list = (from t in menus
                        where t.ParentId == menuId
                        select t).ToList();

            foreach (var item in list)
            {
                await DeleteRoleMenu(roleId, item.Id);
            }
        }

        public async Task<Response<string>> CreateRoleMenu(int roleId, string menuIds)
        {
            var result = new Response<string>();

            string[] array = menuIds.Split(",");

            await roleMenus.DeleteAsync(t => t.RoleId == roleId);

            foreach (var item in array)
            {
                await roleMenus.InsertAsync(new RoleMenu() { RoleId = roleId, MenuId = item.TryToInt() });
            }

            result.msg = "角色权限分配成功！";

            return result;
        }
    }
}