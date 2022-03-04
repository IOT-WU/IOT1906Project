using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDB.Migrations
{
    public partial class v15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Annual_details",
                columns: table => new
                {
                    Annual_Did = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Annual_jobs = table.Column<int>(type: "int", nullable: false),
                    Annual_existing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Annual_January = table.Column<int>(type: "int", nullable: false),
                    Annual_February = table.Column<int>(type: "int", nullable: false),
                    Annual_march = table.Column<int>(type: "int", nullable: false),
                    Annual_April = table.Column<int>(type: "int", nullable: false),
                    Annual_may = table.Column<int>(type: "int", nullable: false),
                    Annual_June = table.Column<int>(type: "int", nullable: false),
                    Annual_July = table.Column<int>(type: "int", nullable: false),
                    Annual_August = table.Column<int>(type: "int", nullable: false),
                    Annual_September = table.Column<int>(type: "int", nullable: false),
                    Annual_October = table.Column<int>(type: "int", nullable: false),
                    Annual_November = table.Column<int>(type: "int", nullable: false),
                    Annual_December = table.Column<int>(type: "int", nullable: false),
                    Annual_combined = table.Column<int>(type: "int", nullable: false),
                    Annual_note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annual_details", x => x.Annual_Did);
                });

            migrationBuilder.CreateTable(
                name: "Annual_information",
                columns: table => new
                {
                    Annual_Fid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    TAB_people = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TAB_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TAB_department = table.Column<int>(type: "int", nullable: false),
                    TAB_year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Annual_detailsDetail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annual_information", x => x.Annual_Fid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Annual_details");

            migrationBuilder.DropTable(
                name: "Annual_information");
        }
    }
}
