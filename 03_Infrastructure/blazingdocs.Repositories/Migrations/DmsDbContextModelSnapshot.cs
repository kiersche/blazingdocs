﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using blazingdocs.core.Model;

#nullable disable

namespace blazingdocs.Repositories.Migrations
{
    [DbContext(typeof(DmsDbContext))]
    partial class DmsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("blazingdocs.core.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("blazingdocs.core.Model.File", b =>
                {
                    b.Property<int>("FileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FileId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OriginalFilename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VirtualObjectId")
                        .HasColumnType("int");

                    b.HasKey("FileId");

                    b.HasIndex("VirtualObjectId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("blazingdocs.core.Model.PhysicalObject", b =>
                {
                    b.Property<int>("PhysicalObjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhysicalObjectId"), 1L, 1);

                    b.Property<int?>("IndexInContainer")
                        .HasColumnType("int");

                    b.Property<int>("PhysicalObjectContainerId")
                        .HasColumnType("int");

                    b.Property<int>("VirtualObjectId")
                        .HasColumnType("int");

                    b.HasKey("PhysicalObjectId");

                    b.HasIndex("PhysicalObjectContainerId");

                    b.HasIndex("VirtualObjectId")
                        .IsUnique();

                    b.ToTable("PhysicalObjects");
                });

            modelBuilder.Entity("blazingdocs.core.Model.PhysicalObjectContainer", b =>
                {
                    b.Property<int>("PhysicalObjectContainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PhysicalObjectContainerId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("PhysicalObjectContainerId");

                    b.HasIndex("ParentId");

                    b.ToTable("PhysicalObjectContainers");
                });

            modelBuilder.Entity("blazingdocs.core.Model.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyId"), 1L, 1);

                    b.Property<int>("PropertyFieldId")
                        .HasColumnType("int");

                    b.Property<int?>("PropertyValueId")
                        .HasColumnType("int");

                    b.Property<int>("VirtualObjectId")
                        .HasColumnType("int");

                    b.HasKey("PropertyId");

                    b.HasIndex("PropertyFieldId");

                    b.HasIndex("PropertyValueId")
                        .IsUnique()
                        .HasFilter("[PropertyValueId] IS NOT NULL");

                    b.HasIndex("VirtualObjectId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("blazingdocs.core.Model.PropertyField", b =>
                {
                    b.Property<int>("PropertyFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyFieldId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyType")
                        .HasColumnType("int");

                    b.Property<int?>("VirtualObjectTypeId")
                        .HasColumnType("int");

                    b.HasKey("PropertyFieldId");

                    b.HasIndex("VirtualObjectTypeId");

                    b.ToTable("PropertyFields");
                });

            modelBuilder.Entity("blazingdocs.core.Model.PropertyValue", b =>
                {
                    b.Property<int>("PropertyValueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PropertyValueId"), 1L, 1);

                    b.Property<DateTime?>("DateTimeValue")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateValue")
                        .HasColumnType("datetime2");

                    b.Property<float?>("FloatValue")
                        .HasColumnType("real");

                    b.Property<decimal?>("MoneyValue")
                        .HasColumnType("decimal(19,4)");

                    b.Property<int?>("NumberValue")
                        .HasColumnType("int");

                    b.Property<string>("TextValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PropertyValueId");

                    b.ToTable("PropertyValues");
                });

            modelBuilder.Entity("blazingdocs.core.Model.VirtualObject", b =>
                {
                    b.Property<int>("VirtualObjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VirtualObjectId"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VirtualObjectTypeId")
                        .HasColumnType("int");

                    b.HasKey("VirtualObjectId");

                    b.HasIndex("VirtualObjectTypeId");

                    b.ToTable("Objects");
                });

            modelBuilder.Entity("blazingdocs.core.Model.VirtualObjectType", b =>
                {
                    b.Property<int>("VirtualObjectTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VirtualObjectTypeId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("VirtualObjectTypeId");

                    b.HasIndex("ParentId");

                    b.ToTable("ObjectTypes");
                });

            modelBuilder.Entity("CategoryVirtualObject", b =>
                {
                    b.Property<int>("CategoriesCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("ObjectsVirtualObjectId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesCategoryId", "ObjectsVirtualObjectId");

                    b.HasIndex("ObjectsVirtualObjectId");

                    b.ToTable("CategoryVirtualObject");
                });

            modelBuilder.Entity("blazingdocs.core.Model.File", b =>
                {
                    b.HasOne("blazingdocs.core.Model.VirtualObject", "VirtualObject")
                        .WithMany("Files")
                        .HasForeignKey("VirtualObjectId");

                    b.Navigation("VirtualObject");
                });

            modelBuilder.Entity("blazingdocs.core.Model.PhysicalObject", b =>
                {
                    b.HasOne("blazingdocs.core.Model.PhysicalObjectContainer", "PhysicalObjectContainer")
                        .WithMany("PhysicalObjects")
                        .HasForeignKey("PhysicalObjectContainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazingdocs.core.Model.VirtualObject", "VirtualObject")
                        .WithOne("PhysicalObject")
                        .HasForeignKey("blazingdocs.core.Model.PhysicalObject", "VirtualObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhysicalObjectContainer");

                    b.Navigation("VirtualObject");
                });

            modelBuilder.Entity("blazingdocs.core.Model.PhysicalObjectContainer", b =>
                {
                    b.HasOne("blazingdocs.core.Model.PhysicalObjectContainer", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("blazingdocs.core.Model.Property", b =>
                {
                    b.HasOne("blazingdocs.core.Model.PropertyField", "PropertyField")
                        .WithMany()
                        .HasForeignKey("PropertyFieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazingdocs.core.Model.PropertyValue", "PropertyValue")
                        .WithOne("Property")
                        .HasForeignKey("blazingdocs.core.Model.Property", "PropertyValueId");

                    b.HasOne("blazingdocs.core.Model.VirtualObject", "VirtualObject")
                        .WithMany("Properties")
                        .HasForeignKey("VirtualObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PropertyField");

                    b.Navigation("PropertyValue");

                    b.Navigation("VirtualObject");
                });

            modelBuilder.Entity("blazingdocs.core.Model.PropertyField", b =>
                {
                    b.HasOne("blazingdocs.core.Model.VirtualObjectType", null)
                        .WithMany("PropertyFields")
                        .HasForeignKey("VirtualObjectTypeId");
                });

            modelBuilder.Entity("blazingdocs.core.Model.VirtualObject", b =>
                {
                    b.HasOne("blazingdocs.core.Model.VirtualObjectType", "VirtualObjectType")
                        .WithMany("Objects")
                        .HasForeignKey("VirtualObjectTypeId");

                    b.Navigation("VirtualObjectType");
                });

            modelBuilder.Entity("blazingdocs.core.Model.VirtualObjectType", b =>
                {
                    b.HasOne("blazingdocs.core.Model.VirtualObjectType", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("CategoryVirtualObject", b =>
                {
                    b.HasOne("blazingdocs.core.Model.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("blazingdocs.core.Model.VirtualObject", null)
                        .WithMany()
                        .HasForeignKey("ObjectsVirtualObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("blazingdocs.core.Model.PhysicalObjectContainer", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("PhysicalObjects");
                });

            modelBuilder.Entity("blazingdocs.core.Model.PropertyValue", b =>
                {
                    b.Navigation("Property")
                        .IsRequired();
                });

            modelBuilder.Entity("blazingdocs.core.Model.VirtualObject", b =>
                {
                    b.Navigation("Files");

                    b.Navigation("PhysicalObject");

                    b.Navigation("Properties");
                });

            modelBuilder.Entity("blazingdocs.core.Model.VirtualObjectType", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("Objects");

                    b.Navigation("PropertyFields");
                });
#pragma warning restore 612, 618
        }
    }
}
