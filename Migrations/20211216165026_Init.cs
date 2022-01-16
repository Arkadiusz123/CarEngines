using Microsoft.EntityFrameworkCore.Migrations;

namespace CarEngines.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity_ccm = table.Column<int>(type: "int", nullable: false),
                    Power_HP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Torque_Nm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfProduction = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Engines");
        }
    }
}
