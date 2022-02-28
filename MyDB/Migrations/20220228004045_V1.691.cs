using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDB.Migrations
{
    public partial class V1691 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    staff_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    staff_department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    staff_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    staff_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_explain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_existing = table.Column<int>(type: "int", nullable: false),
                    staff_recruit = table.Column<int>(type: "int", nullable: false),
                    staff_sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_age = table.Column<int>(type: "int", nullable: false),
                    staff_Culture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_major = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_post = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_Salary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_contract = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_probation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    staff_application = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_enclosure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    staff_remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.staff_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resources");
        }
    }
}
