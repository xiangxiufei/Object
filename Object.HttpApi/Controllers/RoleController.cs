using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Object.Application.Contracts.Object;
using Object.Domain.Shared;
using Object.Domain.Shared.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using static Object.Domain.Shared.Jwt;

namespace Object.HttpApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class RoleController : AbpController
    {
        private readonly IRoleService service;
        private readonly IHttpContextAccessor http;

        public RoleController(IRoleService service, IHttpContextAccessor http)
        {
            this.service = service;
            this.http = http;
        }

        [HttpGet]
        public async Task<Response<List<RoleTree>>> GetRoleTree()
        {
            return await service.GetRoleTree();
        }
    }
}