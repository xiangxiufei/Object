using log4net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Volo.Abp.Validation;

namespace Object.HttpApi.Filters
{
    public class ValidationExceptionFilter : IExceptionFilter
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ValidationExceptionFilter));

        public void OnException(ExceptionContext context)
        {
            if (context.Exception is AbpValidationException)
            {
                log.Error($"{context.HttpContext.Request.Path}|{context.Exception.Message}", context.Exception);

                var validateerros = ((AbpValidationException)context.Exception).ValidationErrors;

                context.Result = new JsonResult(new { Code = 500, Msg = validateerros.Count > 0 ? validateerros[0].ErrorMessage : context.Exception.Message, Data = "" });

                context.ExceptionHandled = true;
            }
        }
    }
}