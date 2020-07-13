using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Object.Application.Contracts.Object;
using Object.Domain.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace Object.HttpApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class RoleController : AbpController
    {
        private readonly IRoleService service;

        public RoleController(IRoleService service, IHttpContextAccessor http)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<Response<List<RoleTree>>> GetRoleTree()
        {
            return await service.GetRoleTree();
        }

        [HttpPost]
        public async Task<Response<string>> CreateRole([FromBody]RoleDto dto)
        {
            return await service.CreateRole(dto);
        }

        [HttpGet("{id}")]
        public async Task<Response<RoleIdDto>> GetRole([FromRoute] int id)
        {
            return await service.GetRole(id);
        }

        [HttpPut("{id}")]
        public async Task<Response<string>> UpdateRole([FromRoute]int id, [FromBody] RoleDto dto)
        {
            return await service.UpdateRole(id, dto);
        }

        [HttpDelete("{id}")]
        public async Task<Response<string>> DeleteRole([FromRoute]int id)
        {
            return await service.DeleteRole(id);
        }

        [HttpDelete("{roleId}/menu/{menuId}")]
        public async Task<Response<RoleTree>> DeleteRoleMenu([FromRoute]int roleId, [FromRoute]int menuId)
        {
            return await service.DeleteRoleMenus(roleId, menuId);
        }
    }
}