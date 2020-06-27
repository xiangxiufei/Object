using log4net;
using Microsoft.AspNetCore.Http;
using Object.Domain.Shared;
using Object.Domain.Shared.Extensions;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Object.HttpApi.Middleware
{
    public class ObjectExceptionHandlerMiddleware
    {
        private readonly RequestDelegate next;
        private static readonly ILog log = LogManager.GetLogger(typeof(ObjectExceptionHandlerMiddleware));

        public ObjectExceptionHandlerMiddleware(RequestDelegate next)
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
            if (e == null) return;

            log.Error($"{context.Request.Path}|{e.Message}", e);

            await WriteExceptionAsync(context, e);
        }

        private static async Task WriteExceptionAsync(HttpContext context, Exception e)
        {
            if (e is UnauthorizedAccessException)
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            else if (e is Exception)
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;

            context.Response.ContentType = "application/json";

            await context.Response.WriteAsync((new ApiResponse(StatusCode.CODE500, e.Message)).response.ToJson());
        }
    }
}