using Microsoft.Extensions.DependencyInjection;
using WebApiApoloGames.Repository.Interfaces;
using WebApiApoloGames.Repository.Repositories;

namespace WebApiApoloGames.Repository
{
    public static class RepositoryCollectionExtension
    {
        public static IServiceCollection AddRepositoryServices (this IServiceCollection services)
        {
            services.AddTransient<IDaysRepository, DaysRepository>();

            return services;
        }
    }
}
