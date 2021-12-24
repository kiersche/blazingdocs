using Microsoft.EntityFrameworkCore;

namespace blazingdocs.Repositories
{
    internal class ConfigurationDbContext : DbContext
    {
        public DbSet<Configuration> Configurations { get; set; } = null!;

        public ConfigurationDbContext() { }

        public ConfigurationDbContext(DbContextOptions<ConfigurationDbContext> options) : base(options)
        { }
    }
}
