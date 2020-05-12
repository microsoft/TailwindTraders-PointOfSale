// *************************************************************************************
//  <copyright file="Startup.cs" company="Mobilize.Net">
//       Copyright (c) 2018 Mobilize, Inc. All Rights Reserved,
//       All classes are provided for customer use only,
//       all other use is prohibited without prior written consent from Mobilize.Net,
//       no warranty express or implied,
//       use at own risk.
//  </copyright>
//  <summary></summary>
// *************************************************************************************

namespace WebSite
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.Extensions.DependencyInjection;
    using Mobilize.Web;
    using Mobilize.WebMap.Common.Core;
    using Mobilize.WebMap.Common.DCP;
    using Mobilize.WebMap.Host;
    using Mobilize.WebMap.Server;
    using Mobilize.WebMap.Server.ObservableBinder;
    using Microsoft.AspNetCore;
    using Microsoft.Extensions.Hosting;
    using Microsoft.AspNetCore.Server.Kestrel.Core;

    /// <summary>
    /// Startup
    /// </summary>
    public partial class Startup
    {
        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        /// </summary>
        /// <param name="services">the collection of services</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddWebMap();
            services.RegisterModelMappers();
            services.RegisterWrappers();
            services.AddSingleton<ICommandFactory, CommandFactory>();
            // Configure the Application
            services.AddScoped<IApplication, MyApplication>();
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddAntiforgery(options => options.HeaderName = WebMapHeaders.AntiforgeryToken);
            services.AddMvc(options =>
                        {
                            options.ModelBinderProviders.Insert(0, new ObservableModelBinderProvider());
                            options.ModelMetadataDetailsProviders.Insert(0, new SuppressChildValidationMetadataProvider(typeof(IObservable)));
                        });
            // If using IIS:
            services.Configure<IISServerOptions>(options => options.AllowSynchronousIO = true);
            // If using Kestrel:
            services.Configure<KestrelServerOptions>(options => options.AllowSynchronousIO = true);
            services.AddHealthChecks();
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline
        /// </summary>
        /// <param name="app">the application builder</param>
        /// <param name="env">the hosting environment</param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAntiforgeryToken();
            app.UseWebMap();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("DefaultApi", "api/{controller}/{id}");
                endpoints.MapHealthChecks("/health");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }

        /// <summary>
        /// Entry Point of the web Application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
    
            BuildWebHost(args).Run();
        }

        /// <summary>
        /// Returns a new WebHost
        /// </summary>
        /// <param name="args">run arguments</param>
        /// <returns>a new WebHost</returns>
        public static IWebHost BuildWebHost(string[] args){
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
        }

    }
}
