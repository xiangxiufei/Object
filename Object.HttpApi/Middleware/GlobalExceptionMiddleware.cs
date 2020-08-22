﻿using log4net;
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
            log.Error($"{context.Request.Path}|{e.Message}", e);

            context.Response.ContentType = "application/json";

            var result = new ApiResponse(StatusCode.CODE500, e.Message).response.ToJson();

            //var result = (new ApiResponse(StatusCode.CODE500)).response.ToJson();

            await context.Response.WriteAsync(result);
        }
    }
}