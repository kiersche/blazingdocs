using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class DmsDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<VirtualObject> Objects { get; set; }
        public DbSet<VirtualObjectType> ObjectTypes { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<PhysicalObject> PhysicalObjects { get; set; }
        public DbSet<PhysicalObjectContainer> PhysicalObjectContainers { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyField> PropertyFields { get; set; }
        public DbSet<PropertyValue> PropertyValues { get; set; }

        public DmsDbContext() { }

        public DmsDbContext(DbContextOptions<DmsDbContext> options) : base(options)
        { }
    }
}
