using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazingdocs.Repositories.Migrations
{
    public partial class ChangeOptionalities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Objects_ObjectId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Objects_ObjectTypes_ObjectTypeId",
                table: "Objects");

            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalObjects_Objects_ObjectId",
                table: "PhysicalObjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Objects_ObjectId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyFields_ObjectTypes_ObjectTypeId",
                table: "PropertyFields");

            migrationBuilder.DropTable(
                name: "CategoryObject");

            migrationBuilder.DropIndex(
                name: "IX_Files_ObjectId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "ObjectId",
                table: "Files");

            migrationBuilder.RenameColumn(
                name: "ObjectTypeId",
                table: "PropertyFields",
                newName: "VirtualObjectTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyFields_ObjectTypeId",
                table: "PropertyFields",
                newName: "IX_PropertyFields_VirtualObjectTypeId");

            migrationBuilder.RenameColumn(
                name: "ObjectId",
                table: "Properties",
                newName: "VirtualObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_ObjectId",
                table: "Properties",
                newName: "IX_Properties_VirtualObjectId");

            migrationBuilder.RenameColumn(
                name: "ObjectId",
                table: "PhysicalObjects",
                newName: "VirtualObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_PhysicalObjects_ObjectId",
                table: "PhysicalObjects",
                newName: "IX_PhysicalObjects_VirtualObjectId");

            migrationBuilder.RenameColumn(
                name: "ObjectTypeId",
                table: "ObjectTypes",
                newName: "VirtualObjectTypeId");

            migrationBuilder.RenameColumn(
                name: "ObjectTypeId",
                table: "Objects",
                newName: "VirtualObjectTypeId");

            migrationBuilder.RenameColumn(
                name: "ObjectId",
                table: "Objects",
                newName: "VirtualObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Objects_ObjectTypeId",
                table: "Objects",
                newName: "IX_Objects_VirtualObjectTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "TextValue",
                table: "PropertyValues",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "MoneyValue",
                table: "PropertyValues",
                type: "decimal(19,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IndexInContainer",
                table: "PhysicalObjects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Files",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "OriginalFilename",
                table: "Files",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VirtualObjectId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryVirtualObject",
                columns: table => new
                {
                    CategoriesCategoryId = table.Column<int>(type: "int", nullable: false),
                    ObjectsVirtualObjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryVirtualObject", x => new { x.CategoriesCategoryId, x.ObjectsVirtualObjectId });
                    table.ForeignKey(
                        name: "FK_CategoryVirtualObject_Categories_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryVirtualObject_Objects_ObjectsVirtualObjectId",
                        column: x => x.ObjectsVirtualObjectId,
                        principalTable: "Objects",
                        principalColumn: "VirtualObjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Files_VirtualObjectId",
                table: "Files",
                column: "VirtualObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryVirtualObject_ObjectsVirtualObjectId",
                table: "CategoryVirtualObject",
                column: "ObjectsVirtualObjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Objects_VirtualObjectId",
                table: "Files",
                column: "VirtualObjectId",
                principalTable: "Objects",
                principalColumn: "VirtualObjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Objects_ObjectTypes_VirtualObjectTypeId",
                table: "Objects",
                column: "VirtualObjectTypeId",
                principalTable: "ObjectTypes",
                principalColumn: "VirtualObjectTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhysicalObjects_Objects_VirtualObjectId",
                table: "PhysicalObjects",
                column: "VirtualObjectId",
                principalTable: "Objects",
                principalColumn: "VirtualObjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Objects_VirtualObjectId",
                table: "Properties",
                column: "VirtualObjectId",
                principalTable: "Objects",
                principalColumn: "VirtualObjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyFields_ObjectTypes_VirtualObjectTypeId",
                table: "PropertyFields",
                column: "VirtualObjectTypeId",
                principalTable: "ObjectTypes",
                principalColumn: "VirtualObjectTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Objects_VirtualObjectId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Objects_ObjectTypes_VirtualObjectTypeId",
                table: "Objects");

            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalObjects_Objects_VirtualObjectId",
                table: "PhysicalObjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Objects_VirtualObjectId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyFields_ObjectTypes_VirtualObjectTypeId",
                table: "PropertyFields");

            migrationBuilder.DropTable(
                name: "CategoryVirtualObject");

            migrationBuilder.DropIndex(
                name: "IX_Files_VirtualObjectId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "OriginalFilename",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "VirtualObjectId",
                table: "Files");

            migrationBuilder.RenameColumn(
                name: "VirtualObjectTypeId",
                table: "PropertyFields",
                newName: "ObjectTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyFields_VirtualObjectTypeId",
                table: "PropertyFields",
                newName: "IX_PropertyFields_ObjectTypeId");

            migrationBuilder.RenameColumn(
                name: "VirtualObjectId",
                table: "Properties",
                newName: "ObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Properties_VirtualObjectId",
                table: "Properties",
                newName: "IX_Properties_ObjectId");

            migrationBuilder.RenameColumn(
                name: "VirtualObjectId",
                table: "PhysicalObjects",
                newName: "ObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_PhysicalObjects_VirtualObjectId",
                table: "PhysicalObjects",
                newName: "IX_PhysicalObjects_ObjectId");

            migrationBuilder.RenameColumn(
                name: "VirtualObjectTypeId",
                table: "ObjectTypes",
                newName: "ObjectTypeId");

            migrationBuilder.RenameColumn(
                name: "VirtualObjectTypeId",
                table: "Objects",
                newName: "ObjectTypeId");

            migrationBuilder.RenameColumn(
                name: "VirtualObjectId",
                table: "Objects",
                newName: "ObjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Objects_VirtualObjectTypeId",
                table: "Objects",
                newName: "IX_Objects_ObjectTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "TextValue",
                table: "PropertyValues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MoneyValue",
                table: "PropertyValues",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(19,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IndexInContainer",
                table: "PhysicalObjects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Files",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ObjectId",
                table: "Files",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Files_ObjectId",
                table: "Files",
                column: "ObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryObject_ObjectsObjectId",
                table: "CategoryObject",
                column: "ObjectsObjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Objects_ObjectId",
                table: "Files",
                column: "ObjectId",
                principalTable: "Objects",
                principalColumn: "ObjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Objects_ObjectTypes_ObjectTypeId",
                table: "Objects",
                column: "ObjectTypeId",
                principalTable: "ObjectTypes",
                principalColumn: "ObjectTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhysicalObjects_Objects_ObjectId",
                table: "PhysicalObjects",
                column: "ObjectId",
                principalTable: "Objects",
                principalColumn: "ObjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Objects_ObjectId",
                table: "Properties",
                column: "ObjectId",
                principalTable: "Objects",
                principalColumn: "ObjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyFields_ObjectTypes_ObjectTypeId",
                table: "PropertyFields",
                column: "ObjectTypeId",
                principalTable: "ObjectTypes",
                principalColumn: "ObjectTypeId");
        }
    }
}
