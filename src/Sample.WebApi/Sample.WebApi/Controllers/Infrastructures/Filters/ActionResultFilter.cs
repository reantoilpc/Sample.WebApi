using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Sample.WebApi.Controllers.ViewModels;

namespace Sample.WebApi.Controllers.Infrastructures.Filters
{
    /// <summary>
    /// 客制 API 回傳格式
    /// </summary>
    public class ActionResultFilter : IAsyncActionFilter
    {
        /// <summary>
        /// Action Execution 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var executedContext = await next();

            if (executedContext.Result is ObjectResult contextResult)
            {
                executedContext.Result = new ObjectResult(new SuccessResultViewModel
                {
                    Id = Guid.NewGuid().ToString(),
                    Method = $"{context.HttpContext.Request.Method} {context.HttpContext.Request.Path}",
                    Version = "1.0",
                    Status = "1000",
                    Data = contextResult?.Value
                });
            }
        }
    }
}