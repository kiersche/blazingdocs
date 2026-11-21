using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazingdocs.Repositories.Migrations;

/// <inheritdoc />
public partial class _20261121141034_AlignEf11Model : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "FullPath",
            table: "Files",
            newName: "RelativePath");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameColumn(
            name: "RelativePath",
            table: "Files",
            newName: "FullPath");
    }
}
