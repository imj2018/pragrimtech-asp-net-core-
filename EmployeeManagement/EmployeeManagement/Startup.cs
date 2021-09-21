using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _config;

        //  using injection/dependency injection
        //
        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            
            // work around
            //
            services.AddMvc(option => option.EnableEndpointRouting = false);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {

            //  middleware
            //  
            //if (env.IsEnvironment("UAT"))
            //if (env.IsProduction())
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //  if a request for static files it will short circuit here, if not it and it is an mvc request
            //  it will pass that to UseMvcWithDefaultRoute
            // 
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();


            //app.Run(async (context) =>
            //{

            //    await context.Response.WriteAsync("Hello");
            //});


        }
    }
}
