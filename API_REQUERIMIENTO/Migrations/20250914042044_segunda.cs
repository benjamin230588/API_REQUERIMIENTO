using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_REQUERIMIENTOS2025.Migrations
{
    /// <inheritdoc />
    public partial class segunda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Requerimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "varchar(200)", nullable: true),
                    Detalle = table.Column<string>(type: "varchar(500)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    ObservacionInicial = table.Column<string>(type: "varchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requerimientos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requerimientos");
        }
    }
}
