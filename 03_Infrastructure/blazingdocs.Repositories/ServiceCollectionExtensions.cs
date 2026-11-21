using blazingdocs.core.Model;
using blazingdocs.Domain;
using blazingdocs.Repositories.Files;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace blazingdocs.Repositories;

public static class ServiceCollectionExtensions
{
    public static void AddRepositories(this IServiceCollection services, string? connectionString)
    {
        services.AddDbContext<DmsDbContext>(options => options.UseSqlServer(connectionString ?? throw new System.InvalidOperationException("Configure ConnectionStrings:Blazingdocs to use SQL Server.")));
        services.AddTransient<IObjectRepository, ObjectRepository>();
        services.AddTransient<IFileRepository, FileRepository>();
    }
}
