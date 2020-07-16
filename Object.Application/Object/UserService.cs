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
        private readonly IRoleRepository roles;
        private readonly IUserRoleRepository userRoles;

        public UserService(IUserRepository users, IRoleRepository roles, IUserRoleRepository userRoles)
        {
            this.users = users;
            this.roles = roles;
            this.userRoles = userRoles;
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

            var list = ((from a in users
                         join b in userRoles on a.Id equals b.UserId into tempb
                         from b in tempb.DefaultIfEmpty()
                         join c in roles on b.RoleId equals c.Id into tempc
                         from c in tempc.DefaultIfEmpty()
                         where string.IsNullOrEmpty(input.Query) || a.Name.Contains(input.Query)
                         orderby a.Id
                         select new UserDto
                         {
                             Id = a.Id,
                             UserName = a.Name,
                             Age = a.Age,
                             Sex = a.Sex,
                             Mobile = a.Mobile,
                             Email = a.Email,
                             Status = a.Status == "0" ? false : true,
                             roleName = c.Name
                         }).Skip(input.PageSize * (input.PageNum - 1))
                           .Take(input.PageSize)).ToList();

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

            result.Success(ObjectMapper.Map<User, UserDto>(user), "用户创建成功！");

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
            await userRoles.DeleteAsync(t => t.UserId == id);

            result.msg = "用户删除成功！";

            return result;
        }

        public async Task<Response<string>> UpdateUserRole(int userId, int roleId)
        {
            var result = new Response<string>();

            var userRole = await userRoles.FindAsync(t => t.UserId == userId);

            if (userRole == null)
            {
                await userRoles.InsertAsync(new UserRole() { UserId = userId, RoleId = roleId });
            }
            else
            {
                userRole.RoleId = roleId;
                await userRoles.UpdateAsync(userRole);
            }

            result.msg = "用户角色分配成功！";

            return result;
        }
    }
}