using BlastoiseApp.Data.Contexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace BlastoiseApp.Config
{
    public static class WebDependencies
    {
        public static void Init(IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            CultureConfig();
            ClientsConfig(services);
           // AddContext(services, configuration);
            AddServices(services);

            services.AddMvc();
        }


        private static void CultureConfig()
        {
            var cultureInfo = new CultureInfo("pt-BR");
            cultureInfo.NumberFormat.CurrencySymbol = "R$";

            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;
        }


        private static void ClientsConfig(IServiceCollection services) => services.AddHttpClient();

        private static void AddContext(IServiceCollection services, IConfiguration configuration) =>
        services
            .AddDbContext<BlastoiseAppDbContext>(_ => _
                .UseNpgsql(configuration.GetConnectionString("Main")));

        private static void AddServices(IServiceCollection services)
        {
            //services.AddScoped<IService, Service>();
        }
    }
}
