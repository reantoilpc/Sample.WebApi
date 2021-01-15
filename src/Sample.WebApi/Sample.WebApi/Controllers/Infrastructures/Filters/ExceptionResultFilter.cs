using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Sample.WebApi.Controllers.ViewModels;

namespace Sample.WebApi.Controllers.Infrastructures.Filters
{
    /// <summary>
    /// Exception Filter
    /// </summary>
    public class ExceptionResultFilter : IAsyncExceptionFilter
    {
        /// <summary>
        /// On Exception 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task OnExceptionAsync(ExceptionContext context)
        {
            var failResultViewModel = new FailResultViewModel()
            {
                Id = Guid.NewGuid().ToString(),
                Method = $"{context.HttpContext.Request.Method} {context.HttpContext.Request.Path}",
                Version = "1.0",
                Status = "Error",
                Error = new FailInformation
                {
                    ErrorCode = "4000",
                    ErrorMessage = context.Exception.Message,
                    Description = context.Exception.ToString()
                }
            };

            context.Result = new ObjectResult(failResultViewModel);
            context.ExceptionHandled = true;

            return Task.CompletedTask;
        }
    }
}