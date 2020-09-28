using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pokeball_Database.Context;
using Pokeball_Services.ContractServices;
using Pokeball_Services.EntityServices;
using Pokeball_Services.UtilityServices;
using System.Net.Http;

namespace Pokeball_Game_API.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPKHttpClient, PkHttpClient>();
            services.AddScoped<HttpClient, HttpClient>();
            services.AddScoped<IPokemonService, PokemonService>();
        }       

        public static void AddDBConfiguration(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<PokeballDBContext>(
                option => option.UseSqlServer(connectionString)
                                .EnableSensitiveDataLogging()
                );
        }

        public static void AddLoggerService(this IServiceCollection services)
        {
            //services.AddSingleton<ILoggerManager, LoggerManager>();
        }

        public static void AddCorsDomainConfiguration(this IServiceCollection services, string MyAllowSpecificOrigins)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:4200");
                                      builder.AllowAnyMethod();
                                  });
            });
        }
    }
}