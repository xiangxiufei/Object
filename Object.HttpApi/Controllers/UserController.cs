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

        [HttpGet("{id}")]
        public async Task<Response<UserDto>> GetUser([FromRoute] int id)
        {
            return await service.GetUser(id);
        }

        [HttpGet]
        public async Task<Response<PagedList<UserDto>>> GetUserList([FromQuery] PagingInput input)
        {
            return await service.GetUserList(input);
        }

        [HttpPost]
        public async Task<Response<UserDto>> CreateUser([FromBody]CreateUserDto dto)
        {
            return await service.CreateUser(dto);
        }

        [HttpPut("{id}/status/{status}")]
        public async Task<Response<UserDto>> UpdateUserStatus([FromRoute]int id, [FromRoute] bool status)
        {
            return await service.UpdateUserStatus(id, status);
        }

        [HttpPut("{id}")]
        public async Task<Response<UserDto>> UpdateUser([FromRoute]int id, [FromBody] UpdateUserDto dto)
        {
            return await service.UpdateUser(id, dto);
        }

        [HttpDelete("{id}")]
        public async Task<Response<string>> DeleteUser([FromRoute]int id)
        {
            return await service.DeleteUser(id);
        }

        [HttpPut("{userId}/role/{roleId}")]
        public async Task<Response<string>> UpdateUserRole([FromRoute]int userId, [FromRoute] int roleId)
        {
            return await service.UpdateUserRole(userId, roleId);
        }
    }
}