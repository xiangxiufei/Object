using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Object.Domain.Shared;
using Object.Domain.Shared.Extensions;
using System.Diagnostics;
using System.Threading.Tasks;
using Volo.Abp.Validation;

namespace Object.HttpApi.Filters
{
    public class ObjectCustomFilter : IAsyncActionFilter, IExceptionFilter
    {
        private string actionArguments = string.Empty;
        private static readonly ILog log = LogManager.GetLogger(typeof(ObjectCustomFilter));

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            actionArguments = context.ActionArguments.ToJson();

            Stopwatch Stopwatch = new Stopwatch();
            Stopwatch.Start();

            var resultContext = await next();

            Stopwatch.Stop();

            ApiLog(actionArguments, Stopwatch, resultContext);
        }

        private static void ApiLog(string actionArguments, Stopwatch Stopwatch, ActionExecutedContext resultContext)
        {
            var rydm = Jwt.GetCurrentRydm(resultContext.HttpContext);
            var ip = resultContext.HttpContext.Request.GetClientIp();

            var url = resultContext.HttpContext.Request.Path + resultContext.HttpContext.Request.QueryString;

            var method = resultContext.HttpContext.Request.Method;

            dynamic result = resultContext.Result.GetType().Name == "EmptyResult" ? new { Value = "EmptyResult" } : resultContext.Result as dynamic;

            var msg = "";

            try
            {
                if (result != null)
                {
                    msg = JsonConvert.SerializeObject(result.Value);
                }
            }
            catch (System.Exception)
            {
            }

            if (string.IsNullOrEmpty(rydm))
            {
                log.Info($"地址：{url} \n " +
                         $"方法：{method} \t 客户端ip: {ip} \n " +
                         $"参数：{actionArguments} \n " +
                         $"结果：{msg} \n " +
                         $"耗时：{Stopwatch.Elapsed.TotalMilliseconds} 毫秒");
            }
            else
            {
                log.Info($"地址：{url} \n " +
                     $"方法：{method} \t 当前用户：{rydm} \t 客户端ip：{ip} \n " +
                     $"参数：{actionArguments} \n " +
                     $"结果：{msg} \n " +
                     $"耗时：{Stopwatch.Elapsed.TotalMilliseconds} 毫秒");
            }
        }

        public void OnException(ExceptionContext context)
        {
            string result = string.Empty;

            if (context.Exception is AbpValidationException)
            {
                var validateerros = ((AbpValidationException)context.Exception).ValidationErrors;

                context.Result = new JsonResult(new { code = 500, msg = validateerros.Count > 0 ? validateerros[0].ErrorMessage : context.Exception.Message, data = "" });

                result = new ApiResponse(StatusCode.CODE500, validateerros.Count > 0 ? validateerros[0].ErrorMessage : context.Exception.Message).response.ToJson();
            }
            else
            {
                context.Result = new JsonResult(new { code = 500, msg = context.Exception.Message, data = "" });

                result = new ApiResponse(StatusCode.CODE500, context.Exception.Message).response.ToJson();
            }

            context.ExceptionHandled = true;

            var rydm = Jwt.GetCurrentRydm(context.HttpContext);
            var ip = context.HttpContext.Request.GetClientIp();

            var url = context.HttpContext.Request.Path + context.HttpContext.Request.QueryString;

            var method = context.HttpContext.Request.Method;

            if (string.IsNullOrEmpty(rydm))
            {
                log.Error($"地址：{url} \n " +
                     $"方法：{method} \t 客户端ip: {ip} \n " +
                     $"参数：{actionArguments} \n " +
                     $"结果：{result}", context.Exception);
            }
            else
            {
                log.Error($"地址：{url} \n " +
                     $"方法：{method} \t 当前用户：{rydm} \t 客户端ip：{ip} \n " +
                     $"参数：{actionArguments} \n " +
                     $"结果：{result}", context.Exception);
            }
        }
    }
}