using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkingLotApi.Migrations
{
    public partial class ModifyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkingBoys",
                table: "ParkingBoys");

            migrationBuilder.RenameTable(
                name: "ParkingBoys",
                newName: "ParkingBoy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkingBoy",
                table: "ParkingBoy",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ParkingBoy",
                table: "ParkingBoy");

            migrationBuilder.RenameTable(
                name: "ParkingBoy",
                newName: "ParkingBoys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ParkingBoys",
                table: "ParkingBoys",
                column: "Id");
        }
    }
}
