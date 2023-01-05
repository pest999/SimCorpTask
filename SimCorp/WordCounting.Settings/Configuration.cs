using Microsoft.Extensions.DependencyInjection;
using WordCounting.Abstractions;
using WordCounting.BL;

namespace WordCounting.Settings
{
    public class Configuration
    {
        public IServiceCollection services { get; }

        public Configuration(IServiceCollection configuration)
        {
            services = configuration;
            ConfigureServices();
        }

        public void ConfigureServices()
        {
            services.AddSingleton<ICounter, CountingLogic>();
            services.AddScoped(typeof(ICounter), typeof(CountingLogic));

            services.AddTransient<IDisplay, DisplayInConsole>();
            services.AddScoped(typeof(IDisplay), typeof(DisplayInConsole));

            services.AddScoped<IReader, ReadDataFromFile>();
            services.AddScoped(typeof(IReader), typeof(ReadDataFromFile));
        }
    }
}
