using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstDotNetCoreApp.Models;
using FirstDotNetCoreApp.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace FirstDotNetCoreApp
{
    public class Startup
    {
        public Startup(IHostingEnvironment environment)
        {
            var builder = new ConfigurationBuilder().SetBasePath(environment.ContentRootPath).AddJsonFile("appsettings.json");
            Configuration = builder.Build();

        }

        public IConfiguration Configuration { get; set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton(provider => Configuration);
            services.AddSingleton<IGreeter, Greeter>();
            services.AddSingleton<IRestaurentData, RestaurentData>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory,IGreeter greeter)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // we can use this two line of code.
            //app.UseDefaultFiles();
            //app.UseStaticFiles();

            //Instead of that two line we can you just one line 
            app.UseFileServer();
            app.UseMvc(ConfigureRoutes);

            app.Run(async (context) =>
            {
               // throw new System.Exception("error");
                //var greetings = Configuration["greetings"];
                var greetings = greeter.GetAllGreetings();
                await context.Response.WriteAsync(greetings);
            });
        }

        private void ConfigureRoutes(IRouteBuilder route)
        {
            route.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
        }
    }
}

