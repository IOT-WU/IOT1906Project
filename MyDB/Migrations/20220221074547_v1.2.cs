using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDB.Migrations
{
    public partial class v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "UserLogin");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "UserLogin",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
