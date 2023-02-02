using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomTypes_BookingTypes_BookingItemId",
                table: "RoomTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomTypes_RoomActivities_RoomActivityId",
                table: "RoomTypes");

            migrationBuilder.DropIndex(
                name: "IX_RoomTypes_BookingItemId",
                table: "RoomTypes");

            migrationBuilder.DropIndex(
                name: "IX_RoomTypes_RoomActivityId",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "BookingItemId",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "RoomActivityId",
                table: "RoomTypes");

            migrationBuilder.CreateIndex(
                name: "IX_RoomActivities_RoomTypeId",
                table: "RoomActivities",
                column: "RoomTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTypes_RoomTypeId",
                table: "BookingTypes",
                column: "RoomTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTypes_RoomTypes_RoomTypeId",
                table: "BookingTypes",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomActivities_RoomTypes_RoomTypeId",
                table: "RoomActivities",
                column: "RoomTypeId",
                principalTable: "RoomTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTypes_RoomTypes_RoomTypeId",
                table: "BookingTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomActivities_RoomTypes_RoomTypeId",
                table: "RoomActivities");

            migrationBuilder.DropIndex(
                name: "IX_RoomActivities_RoomTypeId",
                table: "RoomActivities");

            migrationBuilder.DropIndex(
                name: "IX_BookingTypes_RoomTypeId",
                table: "BookingTypes");

            migrationBuilder.AddColumn<int>(
                name: "BookingItemId",
                table: "RoomTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomActivityId",
                table: "RoomTypes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypes_BookingItemId",
                table: "RoomTypes",
                column: "BookingItemId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypes_RoomActivityId",
                table: "RoomTypes",
                column: "RoomActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomTypes_BookingTypes_BookingItemId",
                table: "RoomTypes",
                column: "BookingItemId",
                principalTable: "BookingTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomTypes_RoomActivities_RoomActivityId",
                table: "RoomTypes",
                column: "RoomActivityId",
                principalTable: "RoomActivities",
                principalColumn: "Id");
        }
    }
}
