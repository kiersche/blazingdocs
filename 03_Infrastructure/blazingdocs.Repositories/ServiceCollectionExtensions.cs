using blazingdocs.core.Model;
using blazingdocs.Repositories.ObjectManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace blazingdocs.Repositories
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddDbContext<DmsDbContext>(options => options.UseSqlServer(@"Server=localhost,1433\sql1dev;Database=blazingdocs;User Id=userDEV;Password=sk.bld01Dev#1;"));
            services.AddTransient<IObjectRepository, ObjectRepository>();
        }
    }
}
