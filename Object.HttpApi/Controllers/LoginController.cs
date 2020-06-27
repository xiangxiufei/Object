using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Object.Application.Contracts.Default;
using Object.Domain.Shared;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

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

        [HttpPost]
        public async Task<Response<UserResponse>> Login([FromBody] UserRequest user)
        {
            return await service.Login(user);
        }

        [HttpGet]
        [Authorize]
        public string GetTest()
        {
            return "Authorize";
        }
    }
}