using blazingdocs.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace blazingdocs.ApplicationServices
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IConfigurationApplicationService, ConfigurationApplicationService>();
        }
    }
}
