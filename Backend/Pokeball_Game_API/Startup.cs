using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Pokeball_Game_API.API.Extensions;
using Pokeball_Services.UtilityServices;

namespace Pokeball_Game_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDBConfiguration(Configuration.GetConnectionString("PokeballDatabase"));
            //services.AddAutoMapper(typeof(Startup));
            //services.AddRepositories();
            services.AddServices();
            //services.AddLoggerService();
            //services.AddCorsDomainConfiguration(MyAllowSpecificOrigins);
            //services.AddSwaggerGen();
            services.AddHttpClient<PkHttpClient>(client =>
            {
                client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
