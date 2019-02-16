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
