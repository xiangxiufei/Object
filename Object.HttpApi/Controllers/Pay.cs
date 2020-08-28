using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Object.Application.Contracts.DTO;
using Object.Application.Contracts.Smkt;
using Object.Domain.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace Object.HttpApi.Controllers
{
    [Route("Order/[controller]/[action]")]
    [Authorize]
    public class Pay : AbpController
    {
        private readonly IShoppingCartService service;

        public Pay(IShoppingCartService service)
        {
            this.service = service;
        }

        /// <summary>
        /// 币种代码查询
        /// </summary>
        [HttpGet]
        public async Task<Response<List<PaymentMethod>>> GetPaymentMethods()
        {
            return await service.GetPaymentMethods();
        }
    }
}