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

        [HttpGet("{type}")]
        public async Task<string> GetMenu([FromRoute]string type)
        {
            return await service.GetMenu(type);
        }
    }
}