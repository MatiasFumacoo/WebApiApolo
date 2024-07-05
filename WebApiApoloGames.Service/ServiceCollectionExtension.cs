using Microsoft.Extensions.DependencyInjection;
using WebApiApoloGames.Service.Interfaces;
using WebApiApoloGames.Service.Services;

namespace WebApiApoloGames.Service
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServices (this IServiceCollection services)
        {
            services.AddTransient<IDaysService, DaysService>();
            services.AddTransient<ISecurityService, SecurityService>();

            return services;
        }
    }
}
