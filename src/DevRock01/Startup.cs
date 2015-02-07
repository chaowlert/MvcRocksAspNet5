using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Logging;
using Microsoft.Framework.Logging.Console;
using DevRock01.Services;
using Microsoft.Framework.ConfigurationModel;

namespace DevRock01
{
    public class Startup
    {
		public void ConfigureServices(IServiceCollection services)
		{
			var config = new Configuration();
			config.AddJsonFile("config.json");

			services.Configure<CalcOptions>(config.GetSubKey("CalcOptions"));
			services.AddInstance<IConfiguration>(config);
			services.AddSingleton<ICalculator, Calculator>();
			services.AddMvc();
		}

		public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole();

			//Hello World
			//app.Run(context => context.Response.WriteAsync("Hello World"));

			//Http Pipeline
			//app.Use(next => context =>
			//{
			//	context.Response.Headers.Append("PowerBy", "MVC");
			//	return next(context);
			//});

			//Custom Middlewares
			//app.UseMiddleware<SampleMiddleware>();

			//Add MVC to the request pipeline
			app.UseMvc(routes =>
			{
				routes.MapRoute(
					name: "default",
					template: "{controller}/{action}/{id?}",
					defaults: new { controller = "Home", action = "Index" });
			});

			// Add static files to the request pipeline
			app.UseStaticFiles();
		}
	}
}
