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
    public class PayController : AbpController
    {
        private readonly IOrderService service;

        public PayController(IOrderService service)
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

        /// <summary>
        /// 保存交易流水
        /// </summary>
        [HttpPost]
        public async Task<Response<string>> SaveGeneralJournal([FromBody]GeneralJournal dto)
        {
            return await service.SaveGeneralJournal(dto);
        }
    }
}