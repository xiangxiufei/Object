using Microsoft.AspNetCore.Mvc;
using Object.Application.Contracts.DTO;
using Object.Application.Contracts.Smkt;
using Object.Domain.Shared;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using static Object.Domain.Shared.Jwt;

namespace Object.HttpApi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AccountController : AbpController
    {
        private readonly IInfo107Service service;

        public AccountController(IInfo107Service service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<Response<UserResponse>> Login([FromForm] UserRequest user)
        {
            return await service.Login(user);
        }
    }
}