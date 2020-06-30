using Object.Domain.Shared;
using System.Threading.Tasks;
using static Object.Domain.Shared.Jwt;

namespace Object.Application.Contracts.Default
{
    public interface IUserService
    {
        Task<Response<UserResponse>> Login(UserRequest request);
    }

    public class UserRequest
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}