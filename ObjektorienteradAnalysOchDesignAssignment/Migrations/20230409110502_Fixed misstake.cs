using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ObjektorienteradAnalysOchDesignAssignment.Migrations
{
    /// <inheritdoc />
    public partial class Fixedmisstake : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Author");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
