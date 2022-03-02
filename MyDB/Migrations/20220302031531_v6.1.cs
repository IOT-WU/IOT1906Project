using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDB.Migrations
{
    public partial class v61 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetingRoomNew");

            migrationBuilder.DropTable(
                name: "ProcurementDetails");

            migrationBuilder.DropTable(
                name: "ProcurementManagement");

            migrationBuilder.DropTable(
                name: "Reception");

            migrationBuilder.DropTable(
                name: "ReceptionItemsDetails");

            migrationBuilder.DropTable(
                name: "ReceptionTripDetails");

            migrationBuilder.DropTable(
                name: "ReservationMeetingRoom");

            migrationBuilder.CreateTable(
                name: "Procurement",
                columns: table => new
                {
                    Procurement_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Procurement_Applicant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procurement_Agent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procurement_ApplyDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procurement_HandlingDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procurement_ApplyTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procurement_HandlingTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Procurement_Use = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procurement", x => x.Procurement_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Procurement");

            migrationBuilder.CreateTable(
                name: "MeetingRoomNew",
                columns: table => new
                {
                    MeetingRoom_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingRoom_Administrator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingRoom_Capacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingRoom_Floor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingRoom_Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingRoom_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingRoom_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingRoom_OrAirConditioner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingRoom_OrNetwork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingRoom_OrNetworkRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingRoom_OrProjector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingRoom_OrWaterDispenser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingRoom_OrWhiteboard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingRoom_Seat = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingRoomNew", x => x.MeetingRoom_Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcurementDetails",
                columns: table => new
                {
                    Goods_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Goods_Money = table.Column<float>(type: "real", nullable: false),
                    Goods_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goods_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goods_Num = table.Column<int>(type: "int", nullable: false),
                    Goods_Price = table.Column<float>(type: "real", nullable: false),
                    Goods_Specifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goods_Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcurementDetails", x => x.Goods_Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcurementManagement",
                columns: table => new
                {
                    Management_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Management_Money = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Management_Name = table.Column<int>(type: "int", nullable: false),
                    Management_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Management_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Management_Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Management_Specifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Management_Unit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcurementManagement", x => x.Management_Id);
                });

            migrationBuilder.CreateTable(
                name: "Reception",
                columns: table => new
                {
                    Reception_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reception_Applicant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_ApplyTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_BeginResidenceTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_Flight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_GuestName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_GuestUnit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_OrData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_OrItems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_OtherRequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_OverResidenceTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reception_Unawares = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reception", x => x.Reception_Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceptionItemsDetails",
                columns: table => new
                {
                    Items_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Items_InventoryQuantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Items_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Items_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Items_NumberRemaining = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Items_Specifications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Items_UseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionItemsDetails", x => x.Items_Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceptionTripDetails",
                columns: table => new
                {
                    Trip_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskId = table.Column<int>(type: "int", nullable: false),
                    Trip_AccompanyingOfficials = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trip_BeginTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trip_Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trip_OrCar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trip_OrHall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trip_OrMeal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trip_OrReservationHotel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trip_OrReservationMeetingRoom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trip_OverTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trip_ParticipateDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trip_Trip = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceptionTripDetails", x => x.Trip_Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservationMeetingRoom",
                columns: table => new
                {
                    Reservation_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reservation_BeginTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reservation_MeetingRoom = table.Column<int>(type: "int", nullable: false),
                    Reservation_OverTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reservation_Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reservation_Seat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reservation_UseDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reservation_Users = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservationMeetingRoom", x => x.Reservation_Id);
                });
        }
    }
}
