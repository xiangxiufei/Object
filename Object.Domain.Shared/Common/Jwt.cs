using Microsoft.IdentityModel.Tokens;
using Object.Domain.Shared.Extensions;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Object.Domain.Shared
{
    public class Jwt
    {
        public static string GetToken(UserResponse user)
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

        public static string GetUserName(string tkoen)
        {
            var jwtHandler = new JwtSecurityTokenHandler();
            JwtSecurityToken jwtToken = jwtHandler.ReadJwtToken(tkoen);

            object userName;
            jwtToken.Payload.TryGetValue(ClaimTypes.Name, out userName);

            return userName.ToString();
        }

        public class UserResponse
        {
            public int Id { get; set; }
            public string UserName { get; set; }
            public string Token { get; set; }
        }
    }
}