using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Object.Domain.Shared;
using Object.Domain.Shared.Extensions;
using System;

namespace Object.HttpApi.Extensions
{
    public static class AuthorizationExtensions
    {
        public static void AddAuthorization(this IServiceCollection service)
        {
            service.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                   .AddJwtBearer(options =>
                  {
                      options.TokenValidationParameters = new TokenValidationParameters
                      {
                          // 是否验证颁发者
                          ValidateIssuer = true,
                          // 是否验证访问群体
                          ValidateAudience = true,
                          // 是否验证生存期
                          ValidateLifetime = true,
                          // 验证Token的时间偏移量
                          ClockSkew = TimeSpan.FromSeconds(30),
                          // 是否验证安全密钥
                          ValidateIssuerSigningKey = true,
                          // 访问群体
                          ValidAudience = AppSettings.JWT.Audience,
                          // 颁发者
                          ValidIssuer = AppSettings.JWT.Issuer,
                          // 安全密钥
                          IssuerSigningKey = new SymmetricSecurityKey(AppSettings.JWT.SecurityKey.GetBytes())
                      };

                      // 应用程序提供的对象，用于处理承载引发的事件，身份验证处理程序
                      options.Events = new JwtBearerEvents
                      {
                          OnChallenge = async context =>
                          {
                              // 跳过默认的处理逻辑，返回下面的模型数据
                              context.HandleResponse();

                              context.Response.ContentType = "application/json;charset=utf-8";
                              context.Response.StatusCode = StatusCodes.Status200OK;

                              await context.Response.WriteAsync((new ApiResponse(StatusCode.CODE401)).response.ToJson());
                          }
                      };
                  });
        }
    }
}