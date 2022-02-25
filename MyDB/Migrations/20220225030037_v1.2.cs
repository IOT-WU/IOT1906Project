using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDB.Migrations
{
    public partial class v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employed",
                columns: table => new
                {
                    Employed_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Employed_Department = table.Column<int>(type: "int", nullable: false),
                    Employed_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployedEntry_JobName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employed_Instruction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employed_Categary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    _Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employed_Sex = table.Column<bool>(type: "bit", nullable: false),
                    Employed_Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Employed_Culture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employed_Health = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employed_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employed_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employed_Specialty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employed_Relative = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employed_Treatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employed_Timelimit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Employed_Thetrial = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employed", x => x.Employed_Id);
                });

            migrationBuilder.CreateTable(
                name: "Relative",
                columns: table => new
                {
                    Relative_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Relative_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relative_Between = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relative_Position = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relative", x => x.Relative_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employed");

            migrationBuilder.DropTable(
                name: "Relative");
        }
    }
}
