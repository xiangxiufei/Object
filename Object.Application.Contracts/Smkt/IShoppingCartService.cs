using Object.Application.Contracts.DTO;
using Object.Domain.Shared;
using System.Threading.Tasks;

namespace Object.Application.Contracts.Smkt
{
    public interface IShoppingCartService
    {
        Task<Response<GoodsDto>> GoodsQuery(GoodsQueryDto query);
    }
}