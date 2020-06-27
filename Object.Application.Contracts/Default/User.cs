using Object.Domain.Shared;
using System.Threading.Tasks;

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

    public class UserResponse
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
    }
}