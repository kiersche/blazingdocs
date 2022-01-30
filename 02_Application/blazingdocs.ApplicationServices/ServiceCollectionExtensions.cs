using blazingdocs.ApplicationServices.Files;
using blazingdocs.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace blazingdocs.ApplicationServices;

public static class ServiceCollectionExtensions
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<IDateTimeProvider, DateTimeProvider>();
        services.AddTransient<IFileApplicationService, FileApplicationService>();
    }
}
