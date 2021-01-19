using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Sample.Service.Dtos;

namespace Sample.WebApi.Controllers.Infrastructures.Attribute
{
    /// <summary>
    /// Attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : System.Attribute, IAsyncAuthorizationFilter
    {
        /// <summary>
        /// On Authorization Async
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var user = (UserDto) context.HttpContext.Items["User"];
            if (user == null)
                context.Result = new JsonResult(new {message = "Unauthorized"})
                    {StatusCode = StatusCodes.Status401Unauthorized};
            return Task.CompletedTask;
        }
    }
}