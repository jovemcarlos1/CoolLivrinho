using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bibliotech.Migrations
{
    /// <inheritdoc />
    public partial class AddCapaUrlToLivroModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CapaUrl",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CapaUrl",
                table: "Livros");
        }
    }
}
