using Microsoft.EntityFrameworkCore;
using Object.Application.Contracts.DTO;
using Object.Application.Contracts.Smkt;
using Object.Domain.Shared;
using Object.Domain.Smkt;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Object.Application.Smkt
{
    public class ShoppingCartService : ApplicationService, IShoppingCartService
    {
        private readonly IRepository<Info200> info200s;
        private readonly IRepository<Info201> info201s;
        private readonly IRepository<Info702> info702s;

        public ShoppingCartService(IRepository<Info200> info200s, IRepository<Info201> info201s, IRepository<Info702> info702s)
        {
            this.info200s = info200s;
            this.info201s = info201s;
            this.info702s = info702s;
        }

        public async Task<Response<List<PaymentMethod>>> GetPaymentMethods()
        {
            var response = new Response<List<PaymentMethod>>();

            var list = await (from a in info702s
                              where a.Qtsybz == "1"
                              select a).ToListAsync();

            var dto = ObjectMapper.Map<List<Info702>, List<PaymentMethod>>(list);

            if (list.Count > 0)
            {
                response.Success(dto);
            }
            else
            {
                response.Failure("未查询到支付方式信息！");
            }

            return response;
        }

        public async Task<Response<GoodsDto>> GoodsQuery(GoodsQueryDto query)
        {
            var response = new Response<GoodsDto>();

            var goods = await (from a in info200s
                               join b in info201s on new { a.CompId, a.Spdm }
                                              equals new { b.CompId, b.Spdm }

                               where a.CompId == query.CompId
                                  && (a.Sptm == query.Sptm || a.Spdm == query.Sptm)

                               select new GoodsDto
                               {
                                   Spdm = a.Spdm,
                                   Spmc = a.Spmc,
                                   Sptm = a.Sptm,
                                   Price = b.Sj
                               }).FirstOrDefaultAsync();

            if (goods != null)
            {
                response.Success(goods);
            }
            else
            {
                response.Failure("未查询到商品信息！");
            }

            return response;
        }
    }
}