using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_REQUERIMIENTOS2025.Migrations
{
    /// <inheritdoc />
    public partial class tercero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ObservacionInicial",
                table: "Requerimientos",
                newName: "Observacion1");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Requerimientos",
                newName: "FechaProgramada");

            migrationBuilder.AddColumn<string>(
                name: "CodigoCliente",
                table: "Requerimientos",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NombreCliente",
                table: "Requerimientos",
                type: "varchar(200)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoCliente",
                table: "Requerimientos");

            migrationBuilder.DropColumn(
                name: "NombreCliente",
                table: "Requerimientos");

            migrationBuilder.RenameColumn(
                name: "Observacion1",
                table: "Requerimientos",
                newName: "ObservacionInicial");

            migrationBuilder.RenameColumn(
                name: "FechaProgramada",
                table: "Requerimientos",
                newName: "Fecha");
        }
    }
}
