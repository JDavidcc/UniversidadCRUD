using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversidadCRUD.Migrations
{
    /// <inheritdoc />
    public partial class Ciclo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ciclo",
                table: "Alumno",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ciclo",
                table: "Alumno");
        }
    }
}
