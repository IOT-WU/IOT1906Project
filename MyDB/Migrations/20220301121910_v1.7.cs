using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDB.Migrations
{
    public partial class v17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Announcement_information",
                columns: table => new
                {
                    Announcement_Fid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Announcement_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Announcement_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Announcement_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Announcement_content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Announcement_attachment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcement_information", x => x.Announcement_Fid);
                });

            migrationBuilder.CreateTable(
                name: "Chapter_information",
                columns: table => new
                {
                    Chapter_Pid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Chapter_applicant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chapter_department = table.Column<int>(type: "int", nullable: false),
                    Chapter_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chapter_sealname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chapter_Checkedout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chapter_Accompanying = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chapter_returndate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chapter_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chapter_content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chapter_note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter_information", x => x.Chapter_Pid);
                });

            migrationBuilder.CreateTable(
                name: "File_information",
                columns: table => new
                {
                    File_Mid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    File_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File_department = table.Column<int>(type: "int", nullable: false),
                    File_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File_Archive = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File_content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    File_attachment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_File_information", x => x.File_Mid);
                });

            migrationBuilder.CreateTable(
                name: "Prints_information",
                columns: table => new
                {
                    Prints_Rid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Prints_applicant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prints_department = table.Column<int>(type: "int", nullable: false),
                    Prints_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prints_printsname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prints_use = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prints_tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prints_note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prints_information", x => x.Prints_Rid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcement_information");

            migrationBuilder.DropTable(
                name: "Chapter_information");

            migrationBuilder.DropTable(
                name: "File_information");

            migrationBuilder.DropTable(
                name: "Prints_information");
        }
    }
}
