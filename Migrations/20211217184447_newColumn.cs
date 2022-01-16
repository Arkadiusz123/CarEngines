using Microsoft.EntityFrameworkCore.Migrations;

namespace CarEngines.Migrations
{
    public partial class newColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfProduction",
                table: "Engines");

            migrationBuilder.AddColumn<int>(
                name: "EndOfProduction",
                table: "Engines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartOfProduction",
                table: "Engines",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndOfProduction",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "StartOfProduction",
                table: "Engines");

            migrationBuilder.AddColumn<string>(
                name: "DateOfProduction",
                table: "Engines",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
