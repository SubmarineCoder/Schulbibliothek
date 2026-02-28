using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schulbibliothek.Migrations
{
    /// <inheritdoc />
    public partial class changesToEntityProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "istAusgeliehen",
                table: "Transaktionen",
                newName: "IstAusgeliehen");

            migrationBuilder.RenameColumn(
                name: "istVerfuegbar",
                table: "Buecher",
                newName: "IstVerfuegbar");

            migrationBuilder.AlterColumn<string>(
                name: "Vorname",
                table: "Personen",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nachname",
                table: "Personen",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BuchName",
                table: "Buecher",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Autor",
                table: "Buecher",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IstAusgeliehen",
                table: "Transaktionen",
                newName: "istAusgeliehen");

            migrationBuilder.RenameColumn(
                name: "IstVerfuegbar",
                table: "Buecher",
                newName: "istVerfuegbar");

            migrationBuilder.AlterColumn<string>(
                name: "Vorname",
                table: "Personen",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Nachname",
                table: "Personen",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "BuchName",
                table: "Buecher",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Autor",
                table: "Buecher",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
