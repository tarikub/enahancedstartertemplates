
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CopilotApiDemo
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // ...existing code...
            services.AddControllers();
            // ...existing code...
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // ...existing code...
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            // ...existing code...
        }
    }
}