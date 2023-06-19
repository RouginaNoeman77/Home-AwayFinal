using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class deletednewdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 19, 37, 7, 723, DateTimeKind.Local).AddTicks(2870));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 19, 31, 38, 259, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.InsertData(
                table: "Property",
                columns: new[] { "Id", "Address", "AdminId", "Area", "AverageRating", "Capacity", "Category", "DateOfAddingProperty", "Description", "NumberOfBathrooms", "NumberOfFloors", "NumberOfRooms", "OwnerId", "PricePerNight", "Region", "State", "Title", "Type" },
                values: new object[,]
                {
                    { 2, "123 Main Street", "e6f12e7d-f393-4990-a6f6-ae8ffc1f4f12", "Beachside", 4.5m, 8, "Vacation Rental", new DateTime(2023, 6, 19, 19, 31, 38, 259, DateTimeKind.Local).AddTicks(4021), "A stunning Apartment with breathtaking views", 3, 2, 4, "fbef741d-ad99-46cd-9e35-4f606638b954", 500.00m, "Coastal", "Pending", "Luxurious Apartment", "Apartment" },
                    { 3, "123 Main Street", "7c35a0d9-5f65-4274-ad98-9741489bd6e8", "DessertSide", 4.5m, 8, "Vacation Rental", new DateTime(2023, 6, 19, 19, 31, 38, 259, DateTimeKind.Local).AddTicks(4032), "A stunning Camp with breathtaking views", 3, 2, 4, "489ce88b-026c-4b20-9c8b-8dd897b3707a", 500.00m, "Coastal", "Pending", "Amazing Camp", "Camp" },
                    { 4, "123 Main Street", "fbef741d-ad99-46cd-9e35-4f606638b953", "Beachside", 4.5m, 8, "Vacation Rental", new DateTime(2023, 6, 19, 19, 31, 38, 259, DateTimeKind.Local).AddTicks(4042), "A stunning House with breathtaking views", 3, 2, 4, "fbef741d-ad99-46cd-9e35-4f606638b951", 500.00m, "Coastal", "Pending", "Luxurious House", "House" }
                });
        }
    }
}
