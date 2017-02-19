using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using LACore.Model;
using LACore.Interfaces;
using LAInfrastructure.Data;
using LAInfrastructure.Services;
using LAInfrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using LAInfrastructure.Common;
using System;

namespace LAWeb
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            var configConnectionString = builder.Build();

            Configuration = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEntityFrameworkConfig(options => options.UseSqlServer(configConnectionString.GetConnectionString("DefaultConnection")))
                .AddEnvironmentVariables().Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration["ConnectionStrings:DefaultConnection"];

            // Add framework services.
            services.AddDbContext<LOTTODBContext>(options => options.UseSqlServer(connection));

            services.AddScoped<DbContext, LOTTODBContext>();
            services.AddScoped<SetDataServiceOptions>(p => new SetDataServiceOptions
            {
                MissingUrl = Configuration["MissingUrl"],
                MissingRegex = Configuration["MissingRegex"],
                OccurenciesRegex = Configuration["OccurenciesRegex"],
                OccurenciesUrl = Configuration["OccurenciesUrl"]
            });

            services.AddScoped<ISetDataService, SetDataService>();
            services.AddScoped<IRepository<Number>, EFRepository<Number>>();
            services.AddScoped<IComputeService>(p=> new ComputeService(Convert.ToDouble(Configuration["Factor1"]), Convert.ToDouble(Configuration["Factor2"])));
            services.AddScoped<IProbabilityService, ProbabilityService>();


            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                {
                    HotModuleReplacement = true
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapSpaFallbackRoute(
                    name: "spa-fallback",
                    defaults: new { controller = "Home", action = "Index" });
            });
        }
    }
}
