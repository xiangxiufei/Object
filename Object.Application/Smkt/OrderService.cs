using Microsoft.EntityFrameworkCore;
using Object.Application.Contracts.DTO;
using Object.Application.Contracts.Smkt;
using Object.Domain.Shared;
using Object.Domain.Smkt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Object.Application.Smkt
{
    public class OrderService : ApplicationService, IOrderService
    {
        private readonly IRepository<Info702> info702s;
        private readonly IRepository<Smkt140> smkt140s;
        private readonly IRepository<Smkt141> smkt141s;
        private readonly IRepository<Smkt142> smkt142s;

        public OrderService(IRepository<Info702> info702s, IRepository<Smkt140> smkt140s,
                            IRepository<Smkt141> smkt141s, IRepository<Smkt142> smkt142s)
        {
            this.info702s = info702s;
            this.smkt140s = smkt140s;
            this.smkt141s = smkt141s;
            this.smkt142s = smkt142s;
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

        public async Task<Response<string>> SaveGeneralJournal(GeneralJournal dto)
        {
            var result = new Response<string>();

            var jyh = await (from a in smkt140s
                             where a.Jysj.Date == DateTime.Now.Date
                             select a.Jyh).MaxAsync();

            if (string.IsNullOrWhiteSpace(jyh))
            {
                jyh = DateTime.Now.ToString("yyyyMMdd") + dto.jyhz.Skjh + "1".PadLeft(5, '0');
            }
            else
            {
                jyh = (long.Parse(jyh) + 1).ToString();
            }

            var jyhz = ObjectMapper.Map<Jyhz, Smkt140>(dto.jyhz);
            var jymx = ObjectMapper.Map<List<Jysp>, List<Smkt141>>(dto.jymx);
            var fkmx = ObjectMapper.Map<List<Jyfs>, List<Smkt142>>(dto.fkmx);

            jyhz.Jyh = jyh;
            await smkt140s.InsertAsync(jyhz);

            for (int i = 0; i < jymx.Count; i++)
            {
                jymx[i].Jyh = jyh;
                await smkt141s.InsertAsync(jymx[i]);
            }

            for (int i = 0; i < fkmx.Count; i++)
            {
                fkmx[i].Jyh = jyh;
                await smkt142s.InsertAsync(fkmx[i]);
            }

            return result;
        }
    }
}