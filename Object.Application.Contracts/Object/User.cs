using Object.Domain.Shared;
using System.Threading.Tasks;
using static Object.Domain.Shared.Jwt;

namespace Object.Application.Contracts.Object
{
    public interface IUserService
    {
        Task<Response<UserResponse>> Login(UserRequest request);

        Task<Response<PagedList<UserDto>>> GetUserList(PagingInput input);

        Task<Response<UserDto>> UpdateUserStatus(int id, bool status);
    }

    public class UserRequest
    {
        public string UserName { get; set; }

        public string Password { get; set; }
    }

    public class UserDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }

        public string Mobile { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; }
    }
}