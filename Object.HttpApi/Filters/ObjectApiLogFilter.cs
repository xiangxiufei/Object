using log4net;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Object.Domain.Shared.Extensions;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Object.HttpApi.Filters
{
    public class ObjectApiLogFilter : IAsyncActionFilter
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ObjectApiLogFilter));

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            string actionArguments = context.ActionArguments.ToJson();

            Stopwatch Stopwatch = new Stopwatch();
            Stopwatch.Start();

            var resultContext = await next();

            Stopwatch.Stop();

            string url = resultContext.HttpContext.Request.Host + resultContext.HttpContext.Request.Path + resultContext.HttpContext.Request.QueryString;

            string method = resultContext.HttpContext.Request.Method;

            dynamic result = resultContext.Result.GetType().Name == "EmptyResult" ? new { Value = "EmptyResult" } : resultContext.Result as dynamic;

            string msg = "";

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

            log.Info($"地址：{url} \n " +
                     $"方法：{method} \n " +
                     $"参数：{actionArguments}\n " +
                     $"结果：{msg}\n " +
                     $"耗时：{Stopwatch.Elapsed.TotalMilliseconds} 毫秒");
        }
    }
}