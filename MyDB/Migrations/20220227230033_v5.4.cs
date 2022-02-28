using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDB.Migrations
{
    public partial class v54 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leave");

            migrationBuilder.CreateTable(
                name: "LeaveType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Leave_TypeId = table.Column<int>(type: "int", nullable: false),
                    Leave_TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveType");

            migrationBuilder.CreateTable(
                name: "Leave",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Leave_AffixName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leave_Day = table.Column<int>(type: "int", nullable: false),
                    Leave_Demo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leave_EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Leave_LeaveType = table.Column<int>(type: "int", nullable: false),
                    Leave_Proposer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leave_Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leave_Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leave_StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Leave_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leave", x => x.Id);
                });
        }
    }
}
