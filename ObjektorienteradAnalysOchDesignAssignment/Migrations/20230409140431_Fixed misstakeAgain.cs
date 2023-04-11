using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ObjektorienteradAnalysOchDesignAssignment.Migrations
{
    /// <inheritdoc />
    public partial class FixedmisstakeAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorArticleRowId",
                table: "Articles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorArticleRowId",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
