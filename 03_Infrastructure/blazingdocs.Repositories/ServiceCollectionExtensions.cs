using blazingdocs.core.Model;
using blazingdocs.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace blazingdocs.Repositories
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddDbContext<DmsDbContext>(options => options.UseSqlServer(@"Server=localhost,1433\sql1dev;Database=blazingdocs;User Id=userDEV;Password=sk.bld01Dev#1;"));
            services.AddDbContext<ConfigurationDbContext>(options => options.UseSqlServer(@"Server=localhost,1433\sql1dev;Database=blazingdocs;User Id=userDEV;Password=sk.bld01Dev#1;"));
            services.AddTransient<IObjectRepository, ObjectRepository>();
            services.AddTransient<IConfigurationRepository, ConfigurationRepository>();
        }
    }
}
