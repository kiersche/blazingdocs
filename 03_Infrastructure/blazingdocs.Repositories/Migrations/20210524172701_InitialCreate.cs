using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace blazingdocs.Repositories.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ObjectTypes",
                columns: table => new
                {
                    ObjectTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectTypes", x => x.ObjectTypeId);
                    table.ForeignKey(
                        name: "FK_ObjectTypes_ObjectTypes_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ObjectTypes",
                        principalColumn: "ObjectTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalObjectContainers",
                columns: table => new
                {
                    PhysicalObjectContainerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalObjectContainers", x => x.PhysicalObjectContainerId);
                    table.ForeignKey(
                        name: "FK_PhysicalObjectContainers_PhysicalObjectContainers_ParentId",
                        column: x => x.ParentId,
                        principalTable: "PhysicalObjectContainers",
                        principalColumn: "PhysicalObjectContainerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyValues",
                columns: table => new
                {
                    PropertyValueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberValue = table.Column<int>(type: "int", nullable: true),
                    FloatValue = table.Column<float>(type: "real", nullable: true),
                    MoneyValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DateValue = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTimeValue = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyValues", x => x.PropertyValueId);
                });

            migrationBuilder.CreateTable(
                name: "Objects",
                columns: table => new
                {
                    ObjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ObjectTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objects", x => x.ObjectId);
                    table.ForeignKey(
                        name: "FK_Objects_ObjectTypes_ObjectTypeId",
                        column: x => x.ObjectTypeId,
                        principalTable: "ObjectTypes",
                        principalColumn: "ObjectTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PropertyFields",
                columns: table => new
                {
                    PropertyFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyType = table.Column<int>(type: "int", nullable: false),
                    ObjectTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyFields", x => x.PropertyFieldId);
                    table.ForeignKey(
                        name: "FK_PropertyFields_ObjectTypes_ObjectTypeId",
                        column: x => x.ObjectTypeId,
                        principalTable: "ObjectTypes",
                        principalColumn: "ObjectTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategoryObject",
                columns: table => new
                {
                    CategoriesCategoryId = table.Column<int>(type: "int", nullable: false),
                    ObjectsObjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryObject", x => new { x.CategoriesCategoryId, x.ObjectsObjectId });
                    table.ForeignKey(
                        name: "FK_CategoryObject_Categories_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryObject_Objects_ObjectsObjectId",
                        column: x => x.ObjectsObjectId,
                        principalTable: "Objects",
                        principalColumn: "ObjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    FileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ObjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.FileId);
                    table.ForeignKey(
                        name: "FK_Files_Objects_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Objects",
                        principalColumn: "ObjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalObjects",
                columns: table => new
                {
                    PhysicalObjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndexInContainer = table.Column<int>(type: "int", nullable: false),
                    PhysicalObjectContainerId = table.Column<int>(type: "int", nullable: false),
                    ObjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalObjects", x => x.PhysicalObjectId);
                    table.ForeignKey(
                        name: "FK_PhysicalObjects_Objects_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Objects",
                        principalColumn: "ObjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalObjects_PhysicalObjectContainers_PhysicalObjectContainerId",
                        column: x => x.PhysicalObjectContainerId,
                        principalTable: "PhysicalObjectContainers",
                        principalColumn: "PhysicalObjectContainerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    PropertyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyFieldId = table.Column<int>(type: "int", nullable: false),
                    PropertyValueId = table.Column<int>(type: "int", nullable: true),
                    ObjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK_Properties_Objects_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "Objects",
                        principalColumn: "ObjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_PropertyFields_PropertyFieldId",
                        column: x => x.PropertyFieldId,
                        principalTable: "PropertyFields",
                        principalColumn: "PropertyFieldId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_PropertyValues_PropertyValueId",
                        column: x => x.PropertyValueId,
                        principalTable: "PropertyValues",
                        principalColumn: "PropertyValueId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryObject_ObjectsObjectId",
                table: "CategoryObject",
                column: "ObjectsObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_ObjectId",
                table: "Files",
                column: "ObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Objects_ObjectTypeId",
                table: "Objects",
                column: "ObjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ObjectTypes_ParentId",
                table: "ObjectTypes",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalObjectContainers_ParentId",
                table: "PhysicalObjectContainers",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalObjects_ObjectId",
                table: "PhysicalObjects",
                column: "ObjectId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalObjects_PhysicalObjectContainerId",
                table: "PhysicalObjects",
                column: "PhysicalObjectContainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ObjectId",
                table: "Properties",
                column: "ObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyFieldId",
                table: "Properties",
                column: "PropertyFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyValueId",
                table: "Properties",
                column: "PropertyValueId",
                unique: true,
                filter: "[PropertyValueId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyFields_ObjectTypeId",
                table: "PropertyFields",
                column: "ObjectTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryObject");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "PhysicalObjects");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "PhysicalObjectContainers");

            migrationBuilder.DropTable(
                name: "Objects");

            migrationBuilder.DropTable(
                name: "PropertyFields");

            migrationBuilder.DropTable(
                name: "PropertyValues");

            migrationBuilder.DropTable(
                name: "ObjectTypes");
        }
    }
}
