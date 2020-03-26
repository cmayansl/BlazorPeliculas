using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorPeliculas.Client.Repositorios;

namespace BlazorPeliculas.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();

            ConfigureServices(builder.Services);
            await builder.Build().RunAsync();
        }
        private static void ConfigureServices(IServiceCollection services)
        {

            // configuraci�n de los servicios de inyecci�n de dependencias
            services.AddOptions();  // Para cuando queramos activar sistema autorizaci�n
            services.AddSingleton<ServicioSingleton>();
            services.AddTransient<ServicioTransient>();
            services.AddScoped<IRepositorio,Repositorio>();
        }
    }
}
