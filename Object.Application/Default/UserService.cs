using Object.Application.Contracts.Default;
using Object.Domain.Default;
using Object.Domain.Shared;
using System.Threading.Tasks;
using static Object.Domain.Shared.Jwt;

namespace Object.Application.Default
{
    public class UserService : ObjectAppService, IUserService
    {
        private readonly IUserRepository users;

        public UserService(IUserRepository users)
        {
            this.users = users;
        }

        public async Task<Response<UserResponse>> Login(UserRequest request)
        {
            var response = new Response<UserResponse>();

            var user = await users.FindAsync(t => t.Name.Equals(request.UserName));

            var dto = ObjectMapper.Map<User, UserResponse>(user);

            if (user != null)
            {
                if (user.Password.Equals(request.Password))
                {
                    dto.Token = GetToken(dto);

                    response.status = 200;
                    response.msg = "登录成功";
                    response.data = dto;
                }
                else
                {
                    response.status = 400;
                    response.msg = "用户密码不正确！";
                }
            }
            else
            {
                response.status = 400;
                response.msg = "用户名不存在！";
            }

            return response;
        }
    }
}