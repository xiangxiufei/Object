using log4net;
using Microsoft.AspNetCore.Http;
using Object.Domain.Shared;
using Object.Domain.Shared.Extensions;
using System;
using System.Threading.Tasks;

namespace Object.HttpApi.Middleware
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate next;
        private static readonly ILog log = LogManager.GetLogger(typeof(GlobalExceptionMiddleware));

        public GlobalExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                await ExceptionHandlerAsync(context, e);
            }
        }

        private async Task ExceptionHandlerAsync(HttpContext context, Exception e)
        {
            context.Response.ContentType = "application/json";

            var result = new ApiResponse(StatusCode.CODE500, e.Message).response.ToJson();
            //var result = (new ApiResponse(StatusCode.CODE500)).response.ToJson();

            ExceptionLog(context, e, result);

            await context.Response.WriteAsync(result);
        }

        private static void ExceptionLog(HttpContext context, Exception e, string result)
        {
            var rydm = Jwt.GetCurrentRydm(context);
            var ip = context.Request.GetClientIp();

            string url = context.Request.Path + context.Request.QueryString;

            string method = context.Request.Method;

            if (string.IsNullOrEmpty(rydm))
            {
                log.Error($"地址：{url} \n " +
                     $"方法：{method} \t 客户端ip: {ip} \n" +
                     $"结果：{result}\n ", e);
            }
            else
            {
                log.Error($"地址：{url} \n " +
                     $"方法：{method} \t 当前用户：{rydm} \t 客户端ip：{ip} \n" +
                     $"结果：{result}\n ", e);
            }
        }
    }
}