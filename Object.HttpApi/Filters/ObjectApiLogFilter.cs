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

            dynamic result = resultContext.Result.GetType().Name == "EmptyResult" ? new { Value = "无返回结果" } : resultContext.Result as dynamic;

            string msg = "在返回结果前发生了异常";

            try
            {
                if (result != null)
                {
                    msg = JsonConvert.SerializeObject(result.Value);
                }
            }
            catch (System.Exception)
            {
                msg = "日志未获取到结果，返回的数据无法序列化";
            }

            log.Info($"地址：{url} \n " +
                     $"方式：{method} \n " +
                     $"参数：{actionArguments}\n " +
                     $"结果：{msg}\n " +
                     $"耗时：{Stopwatch.Elapsed.TotalMilliseconds} 毫秒");
        }
    }
}