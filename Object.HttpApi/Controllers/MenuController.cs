using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Object.Domain.Shared.Extensions;
using static Object.Domain.Shared.Jwt;
using Object.Application.Contracts.Object;
using Object.Domain.Shared;
using System.Collections.Generic;

namespace Object.HttpApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class MenuController : AbpController
    {
        private readonly IMenuService service;
        private readonly IHttpContextAccessor http;

        public MenuController(IMenuService service, IHttpContextAccessor http)
        {
            this.http = http;
            this.service = service;
        }

        [HttpGet]
        public async Task<Response<List<MenuTree>>> GetMenuTree()
        {
            var token = http.HttpContext.Request
                            .Headers["Authorization"]
                            .ToStringX().Replace("Bearer ", "");

            return await service.GetMenuTree(GetUserName(token));
        }
    }
}