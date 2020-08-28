using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Object.Application.Contracts.DTO;
using Object.Application.Contracts.Smkt;
using Object.Domain.Shared;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace Object.HttpApi.Controllers
{
    [Route("ShoppingCart/[controller]/[action]")]
    [Authorize]
    public class GoodsController : AbpController
    {
        private readonly IShoppingCartService service;

        public GoodsController(IShoppingCartService service)
        {
            this.service = service;
        }

        /// <summary>
        /// 商品查询
        /// </summary>
        [HttpPost]
        public async Task<Response<GoodsDto>> Query([FromBody]GoodsQueryDto query)
        {
            return await service.GoodsQuery(query);
        }
    }
}