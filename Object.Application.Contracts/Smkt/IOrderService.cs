using Object.Application.Contracts.DTO;
using Object.Domain.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Object.Application.Contracts.Smkt
{
    public interface IOrderService
    {
        Task<Response<List<PaymentMethod>>> GetPaymentMethods();
        Task<Response<string>> SaveGeneralJournal(GeneralJournal dto);
    }
}