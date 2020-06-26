using Microsoft.AspNetCore.Mvc.Filters;

namespace Object.HttpApi.Filters
{
    public class ObjectExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}