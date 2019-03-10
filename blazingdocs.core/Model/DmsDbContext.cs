using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace blazingdocs.core.Model
{
    public class DmsDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<PhysicalDocument> PhysicalDocuments { get; set; }
        public DbSet<PhysicalDocumentContainer> PhysicalDocumentContainers { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyField> PropertyFields { get; set; }
        public DbSet<PropertyValue> PropertyValues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryDocument>()
                .HasKey(cd => new { cd.CategoryId, cd.DocumentId });

            modelBuilder.Entity<CategoryDocument>()
                .HasOne(cd => cd.Category)
                .WithMany(cd => cd.CategoryDocuments)
                .HasForeignKey(cd => cd.CategoryId);

            modelBuilder.Entity<CategoryDocument>()
                .HasOne(cd => cd.Document)
                .WithMany(cd => cd.CategoryDocuments)
                .HasForeignKey(cd => cd.DocumentId);
        }
    }
}
