using Microsoft.Extensions.DependencyInjection;
using Sample.Service.Implements;
using Sample.Service.Interfaces;

namespace Sample.WebApi.Infrastructures.Extensions
{
    /// <summary>
    /// Service Configuration
    /// </summary>
    public static class ServiceConfigurationExtension
    {
        /// <summary>
        /// Add Custom Services
        /// </summary>
        /// <param name="services"></param>
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}