using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Object.Application.Contracts.Object;
using Object.Domain.Shared;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace Object.HttpApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UserController : AbpController
    {
        private readonly IUserService service;

        public UserController(IUserService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<Response<PagedList<UserDto>>> GetUserList([FromQuery] PagingInput input)
        {
            return await service.GetUserList(input);
        }

        [HttpPut("{id}/status/{status}")]
        public async Task<Response<UserDto>> UpdateUserStatus([FromRoute]int id, [FromRoute] bool status)
        {
            return await service.UpdateUserStatus(id, status);
        }
    }
}