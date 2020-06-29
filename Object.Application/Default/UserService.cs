using Microsoft.IdentityModel.Tokens;
using Object.Application.Contracts.Default;
using Object.Domain.Default;
using Object.Domain.Shared;
using Object.Domain.Shared.Extensions;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;

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

        private string GetToken(UserResponse user)
        {
            var claims = new[] {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Iss,AppSettings.JWT.Issuer),
                    new Claim(JwtRegisteredClaimNames.Aud,AppSettings.JWT.Audience),
                    new Claim(JwtRegisteredClaimNames.Nbf,$"{new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()}"),
                    new Claim(JwtRegisteredClaimNames.Exp,$"{new DateTimeOffset(DateTime.Now.AddSeconds(AppSettings.JWT.Expires)).ToUnixTimeSeconds()}")
                };

            var key = new SymmetricSecurityKey(AppSettings.JWT.SecurityKey.SerializeUtf8());
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var securityToken = new JwtSecurityToken(
                    issuer: AppSettings.JWT.Issuer,
                    audience: AppSettings.JWT.Audience,
                    claims: claims,
                    expires: DateTime.Now.AddSeconds(AppSettings.JWT.Expires),
                    signingCredentials: creds);

            return "Bearer " + new JwtSecurityTokenHandler().WriteToken(securityToken);
        }
    }
}