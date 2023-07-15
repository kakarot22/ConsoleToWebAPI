using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToWebAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //inject new service
            services.AddTransient<CustomMiddleware1>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            ////app.Run(async context =>
            ////{
            ////    await context.Response.WriteAsync("Hello from Run() 1\n");
            ////});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use() 1 of 1\n");

            //    await next();

            //    await context.Response.WriteAsync("Hello from Use() 2 of 1\n");
            //});

            //// use the service by inerting it in http pipline
            //app.UseMiddleware<CustomMiddleware1>();

            //app.Map("/karthik", CustomeCode); 

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from Use() 1 of 2\n");

            //    await next();

            //    await context.Response.WriteAsync("Hello from Use() 2 of 2\n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Complete \n");
            //});

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // this is a middleware
            }

            app.UseRouting(); // middleware, enables routing

            app.UseEndpoints(endpoints => // mapping resource
            {
                endpoints.MapControllers(); // this is routing controller, bridge b/w http pipleine and controllers
            });
        }

        

        private static void CustomeCode(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Karthik \n");
            });
        }
    }
}
