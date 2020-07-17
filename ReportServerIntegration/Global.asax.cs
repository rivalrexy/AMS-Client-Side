using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Microsoft.Extensions.DependencyInjection;
using ReportServerIntegration.Services;

namespace ReportServerIntegration
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DevExtremeBundleConfig.RegisterBundles(BundleTable.Bundles);
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            var services = new ServiceCollection();
            ConfigureServices(services);

            var resolver = new DefaultDependencyResolver(services.BuildServiceProvider());
            DependencyResolver.SetResolver(resolver);


        }



        void ConfigureServices(IServiceCollection serviceCollection)
        {
            var configuration = new AppSettings();
            serviceCollection.AddSingleton<IAppSettings>(configuration);

            var controllers = EnumerateControllers();
            foreach (var controller in controllers)
            {
                serviceCollection.AddTransient(controller);
            }

            serviceCollection.AddHttpClient("reportServer", config => {
                config.BaseAddress = new Uri(configuration.GetValue("ReportServer:BaseUri"));
            });

            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            serviceCollection.AddScoped<ITokenService, TokenService>();
            serviceCollection.AddScoped<IApiService, ApiService>();
            serviceCollection.AddScoped<IReportService, ReportService>();
            serviceCollection.AddScoped<IDashboardService, DashboardService>();
        }

        IEnumerable<Type> EnumerateControllers()
        {
            return typeof(MvcApplication).Assembly.GetTypes()
                .Where(x => !x.IsAbstract)
                .Where(x => x.IsSubclassOf(typeof(System.Web.Mvc.Controller)));
        }
    }
}
