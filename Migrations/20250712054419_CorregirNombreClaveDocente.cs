using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionCursosApi.Migrations
{
    /// <inheritdoc />
    public partial class CorregirNombreClaveDocente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdDocente",
                table: "Cursos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdDocente",
                table: "Cursos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
