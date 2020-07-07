using Object.Application.Contracts.Object;
using Object.Domain.Object;
using Object.Domain.Shared;
using Object.Domain.Shared.Extensions;
using System.Linq;
using System.Threading.Tasks;
using static Object.Domain.Shared.Jwt;

namespace Object.Application.Object
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

        public async Task<Response<PagedList<UserDto>>> GetUserList(PagingInput input)
        {
            var result = new Response<PagedList<UserDto>>();

            var count = await users.GetCountAsync();

            var list = users.Where(t => string.IsNullOrEmpty(input.Query) || t.Name.Contains(input.Query))
                            .OrderBy(t => t.Id)
                            .PageByIndex(input.PageNum, input.PageSize)
                            .Select(t => new UserDto
                            {
                                Id = t.Id,
                                UserName = t.Name,
                                Age = t.Age,
                                Sex = t.Sex,
                                Mobile = t.Mobile,
                                Email = t.Email,
                                Status = t.Status == "0" ? false : true
                            }).ToList();

            result.Success(new PagedList<UserDto>(count.TryToInt(), list));

            return result;
        }

        public async Task<Response<UserDto>> UpdateUserStatus(int id, bool status)
        {
            var result = new Response<UserDto>();

            var user = await users.GetAsync(t => t.Id == id);
            user.Status = status ? "1" : "0";

            var dto = ObjectMapper.Map<User, UserDto>(await users.UpdateAsync(user));
            result.Success(dto, "更新用户状态成功！");

            return result;
        }

        public async Task<Response<UserDto>> CreateUser(CreateUserDto dto)
        {
            var result = new Response<UserDto>();

            var user = await users.InsertAsync(ObjectMapper.Map<CreateUserDto, User>(dto));

            result.Success(ObjectMapper.Map<User, UserDto>(user), "创建成功！");

            return result;
        }

        public async Task<Response<UserDto>> GetUser(int id)
        {
            var result = new Response<UserDto>();

            var user = await users.GetAsync(t => t.Id == id);

            result.Success(ObjectMapper.Map<User, UserDto>(user));

            return result;
        }

        public async Task<Response<UserDto>> UpdateUser(int id, UpdateUserDto dto)
        {
            var result = new Response<UserDto>();

            var user = await users.GetAsync(t => t.Id == id);
            user.Age = dto.Age;
            user.Sex = dto.Sex;
            user.Mobile = dto.Mobile;
            user.Email = dto.Email;

            result.Success(ObjectMapper.Map<User, UserDto>(await users.UpdateAsync(user)), "更新用户信息成功！");

            return result;
        }

        public async Task<Response<string>> DeleteUser(int id)
        {
            var result = new Response<string>();

            await users.DeleteAsync(t => t.Id == id);

            result.msg = "删除成功！";

            return result;
        }
    }
}