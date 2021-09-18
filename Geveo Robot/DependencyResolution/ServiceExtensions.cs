using Geveo.Modules.Robot.Core.Services;
using Geveo.Modules.Robot.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Geveo_Robot.DependencyResolution
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// Method to register services
        /// </summary>
        /// <param name="services"> Service collection</param>
        /// <returns></returns>
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            #region Services DI
            services.AddScoped<IRobotService, RobotService>();
            #endregion Services DI

            return services;
        }
    }
}
