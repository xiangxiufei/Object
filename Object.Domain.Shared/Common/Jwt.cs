using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using Object.Domain.Shared.Extensions;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Object.Domain.Shared
{
    public class Jwt
    {
        public static string GetToken(string rydm)
        {
            var claims = new[] {
                    new Claim(ClaimTypes.Name, rydm),
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

        public static string GetCurrentRydm(HttpContext httpContext)
        {
            var token = httpContext.Request
                       .Headers["Authorization"]
                       .ToStringX().Replace("Bearer ", "");

            if (!string.IsNullOrEmpty(token))
            {
                var jwtHandler = new JwtSecurityTokenHandler();
                JwtSecurityToken jwtToken = jwtHandler.ReadJwtToken(token);

                object rydm;
                jwtToken.Payload.TryGetValue(ClaimTypes.Name, out rydm);

                return rydm.ToString();
            }
            else
            {
                return "";
            }
        }
    }
}