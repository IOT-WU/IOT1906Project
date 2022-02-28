using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDB.Migrations
{
    public partial class v53 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leave",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Leave_LeaveType = table.Column<int>(type: "int", nullable: false),
                    Leave_StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Leave_EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Leave_Day = table.Column<int>(type: "int", nullable: false),
                    Leave_Proposer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leave_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Leave_Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leave_AffixName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leave_Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Leave_Demo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leave", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leave");
        }
    }
}
