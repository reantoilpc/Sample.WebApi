using Microsoft.AspNetCore.Mvc;
using Sample.WebApi.Controllers.Infrastructures.Filters;

namespace Sample.WebApi.Infrastructures.Extensions
{
    /// <summary>
    /// Add Filter Service Extension
    /// </summary>
    public static class FilterExtension
    {
        /// <summary>
        /// 加入客制 Filters
        /// </summary>
        /// <param name="options"></param>
        public static void AddCustomFilters(this MvcOptions options)
        {
            options.Filters.Add<ExceptionResultFilter>();
            options.Filters.Add<ActionResultFilter>();
        }
    }
}