using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ObjektorienteradAnalysOchDesignAssignment.Migrations
{
    /// <inheritdoc />
    public partial class InitFixBug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Author_AuthorEntityId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_AuthorEntityId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "AuthorEntityId",
                table: "Articles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorEntityId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorEntityId",
                table: "Articles",
                column: "AuthorEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Author_AuthorEntityId",
                table: "Articles",
                column: "AuthorEntityId",
                principalTable: "Author",
                principalColumn: "Id");
        }
    }
}
