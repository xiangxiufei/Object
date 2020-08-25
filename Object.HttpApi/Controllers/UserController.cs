using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Object.Application.Contracts;
using Object.Application.Contracts.DTO;
using Object.Application.Contracts.Smkt;
using Object.Domain.Shared;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace Object.HttpApi.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UserController : AbpController
    {
        private readonly IInfo107Service service;

        public UserController(IInfo107Service service)
        {
            this.service = service;
        }

        /// <summary>
        /// 登录
        /// </summary>
        [HttpPost]
        public async Task<Response<LoginDto>> Login([FromBody]LoginRequest request)
        {
            return await service.Login(request);
        }

        [HttpGet]
        [Authorize]
        public async Task<Response<CompDto>> GetCompInfo(string compId)
        {
            return await service.GetCompInfo(compId);
        }
    }
}