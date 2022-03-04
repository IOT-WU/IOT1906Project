using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDB.Migrations
{
    public partial class V158 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "maintains",
                columns: table => new
                {
                    vehicle_BId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vehicle_Handler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicle_datime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vehicle_reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicle_project = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicle_Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicle_cost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicle_Kilometers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicle_remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maintains", x => x.vehicle_BId);
                });

            migrationBuilder.CreateTable(
                name: "mInsurances",
                columns: table => new
                {
                    car_AId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    car_Handler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    car_Tabulation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    car_Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    car_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    car_purchase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    car_seat = table.Column<int>(type: "int", nullable: false),
                    car_money = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    car_passenger = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    car_project = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    car_Insurance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    car_strat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    car_end = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mInsurances", x => x.car_AId);
                });

            migrationBuilder.CreateTable(
                name: "mrepairs",
                columns: table => new
                {
                    CId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Handler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    project = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kilometers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fault = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mrepairs", x => x.CId);
                });

            migrationBuilder.CreateTable(
                name: "mViolations",
                columns: table => new
                {
                    DId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Handler = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    drive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Violation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    money = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    points = table.Column<int>(type: "int", nullable: false),
                    handle = table.Column<DateTime>(type: "datetime2", nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mViolations", x => x.DId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "maintains");

            migrationBuilder.DropTable(
                name: "mInsurances");

            migrationBuilder.DropTable(
                name: "mrepairs");

            migrationBuilder.DropTable(
                name: "mViolations");
        }
    }
}
