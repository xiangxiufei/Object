using Object.Application.Contracts.DTO;
using Object.Domain.Shared;
using System.Threading.Tasks;

namespace Object.Application.Contracts.Smkt
{
    public interface IInfo107Service
    {
        Task<Response<LoginDto>> Login(LoginRequest request);

        Task<Response<CompDto>> GetCompInfo(string compId);
    }
}