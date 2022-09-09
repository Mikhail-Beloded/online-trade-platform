using Microsoft.Extensions.DependencyInjection;
using OnlineTradePlatform.Application.IServices;
using OnlineTradePlatform.Infrastructure.Services;
using OnlineTradePlatform.Infrastructure.Context;
using OnlineTradePlatform.Application.IRepositories;
using OnlineTradePlatform.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace OnlineTradePlatform.Infrastructure
{
    public static class DepdendencyInjection
    {
        public static IServiceCollection ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IAdService, AdService>();
            services.AddScoped<IUsersService, UsersService>();

            return services;
        }

        public static IServiceCollection ConfigureInfrastruction(IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("OnlineTradePlatform");

            services.AddDbContext<EFContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
