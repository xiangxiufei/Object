using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Object.Application.Contracts.Object;
using Object.Domain.Shared;
using Object.HttpApi.Filters;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using static Object.Domain.Shared.Jwt;

namespace Object.HttpApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : AbpController
    {
        private readonly IUserService service;

        public LoginController(IUserService service)
        {
            this.service = service;
        }

        public async Task<Response<UserResponse>> Login([FromBody] UserRequest user)
        {
            return await service.Login(user);
        }
    }
}