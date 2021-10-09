namespace TodoApp.Api
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        #region ConfigureServices
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void ConfigureLocalServices(IServiceCollection services)
        {
            this.ConfigureServices(services);
        }

        public void ConfigureDevelopmentServices(IServiceCollection services)
        {
            this.ConfigureServices(services);
        }

        public void ConfigureStagingServices(IServiceCollection services)
        {
            this.ConfigureServices(services);
        }

        public void ConfigureProductionServices(IServiceCollection services)
        {
            this.ConfigureServices(services);
        }
        #endregion

        #region Configure
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }

        public void ConfigureLocal(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            this.Configure(app, env);
        }

        public void ConfigureDevelopment(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            this.Configure(app, env);
        }

        public void ConfigureStaging(IApplicationBuilder app, IWebHostEnvironment env)
        {
            this.Configure(app, env);
        }

        public void ConfigureProduction(IApplicationBuilder app, IWebHostEnvironment env)
        {
            this.Configure(app, env);
        }
        #endregion
    }
}
