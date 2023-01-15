using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Itau.Challenge.Migrations
{
    /// <inheritdoc />
    public partial class TabelaUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Profile",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "Usuarios",
                newName: "Login");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Usuarios",
                newName: "User");

            migrationBuilder.AddColumn<string>(
                name: "Profile",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
