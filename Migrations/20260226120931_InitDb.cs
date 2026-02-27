using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schulbibliothek.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buecher",
                columns: table => new
                {
                    BuchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    istVerfuegbar = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buecher", x => x.BuchId);
                });

            migrationBuilder.CreateTable(
                name: "Personen",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vorname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nachname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bild = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Aktiv = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personen", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Transaktionen",
                columns: table => new
                {
                    TransaktionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    BuchId = table.Column<int>(type: "int", nullable: false),
                    istAusgeliehen = table.Column<bool>(type: "bit", nullable: false),
                    Datum = table.Column<DateOnly>(type: "date", nullable: false),
                    Beschreibung = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaktionen", x => x.TransaktionId);
                    table.ForeignKey(
                        name: "FK_Transaktionen_Buecher_BuchId",
                        column: x => x.BuchId,
                        principalTable: "Buecher",
                        principalColumn: "BuchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transaktionen_Personen_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Personen",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaktionen_BuchId",
                table: "Transaktionen",
                column: "BuchId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaktionen_PersonId",
                table: "Transaktionen",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transaktionen");

            migrationBuilder.DropTable(
                name: "Buecher");

            migrationBuilder.DropTable(
                name: "Personen");
        }
    }
}
