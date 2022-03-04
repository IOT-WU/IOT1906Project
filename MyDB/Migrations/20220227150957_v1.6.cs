using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDB.Migrations
{
    public partial class v16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Annual_text",
                columns: table => new
                {
                    Tid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanInfoDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annual_text", x => x.Tid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Annual_text");
        }
    }
}
