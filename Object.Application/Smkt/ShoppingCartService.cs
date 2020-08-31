using Microsoft.EntityFrameworkCore;
using Object.Application.Contracts.DTO;
using Object.Application.Contracts.Smkt;
using Object.Domain.Shared;
using Object.Domain.Smkt;
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

        public ShoppingCartService(IRepository<Info200> info200s, IRepository<Info201> info201s)
        {
            this.info200s = info200s;
            this.info201s = info201s;
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