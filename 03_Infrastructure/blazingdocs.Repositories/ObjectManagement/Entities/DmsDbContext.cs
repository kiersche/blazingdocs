using Microsoft.EntityFrameworkCore;

namespace blazingdocs.core.Model
{
    public class DmsDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<VirtualObject> Objects { get; set; } = null!;
        public DbSet<VirtualObjectType> ObjectTypes { get; set; } = null!;
        public DbSet<File> Files { get; set; } = null!;
        public DbSet<PhysicalObject> PhysicalObjects { get; set; } = null!;
        public DbSet<PhysicalObjectContainer> PhysicalObjectContainers { get; set; } = null!;
        public DbSet<Property> Properties { get; set; } = null!;
        public DbSet<PropertyField> PropertyFields { get; set; } = null!;
        public DbSet<PropertyValue> PropertyValues { get; set; } = null!;

        public DmsDbContext() { }

        public DmsDbContext(DbContextOptions<DmsDbContext> options) : base(options)
        { }
    }
}
