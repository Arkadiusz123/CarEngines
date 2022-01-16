using Microsoft.EntityFrameworkCore.Migrations;

namespace CarEngines.Migrations
{
    public partial class ChangeTablesDesign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndOfProduction",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "Power_HP",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "StartOfProduction",
                table: "Engines");

            migrationBuilder.DropColumn(
                name: "Torque_Nm",
                table: "Engines");

            migrationBuilder.AlterColumn<decimal>(
                name: "Fuel_Consumption",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Acceleration_0_100",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AveragePrice_PLN",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EndOfProduction",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "MaxSpeed_KM_H",
                table: "Cars",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtomotoLink",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Power_HP",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StartOfProduction",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Torque_Nm",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acceleration_0_100",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "AveragePrice_PLN",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EndOfProduction",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "MaxSpeed_KM_H",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "OtomotoLink",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Power_HP",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "StartOfProduction",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Torque_Nm",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "EndOfProduction",
                table: "Engines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Power_HP",
                table: "Engines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StartOfProduction",
                table: "Engines",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Torque_Nm",
                table: "Engines",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Fuel_Consumption",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }
    }
}
