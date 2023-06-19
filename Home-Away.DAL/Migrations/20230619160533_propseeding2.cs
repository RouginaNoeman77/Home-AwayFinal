using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class propseeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 19, 5, 33, 631, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 19, 5, 33, 631, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 19, 5, 33, 631, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 19, 5, 33, 631, DateTimeKind.Local).AddTicks(3637));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 18, 45, 30, 132, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 18, 45, 30, 132, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 18, 45, 30, 132, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 18, 45, 30, 132, DateTimeKind.Local).AddTicks(6499));
        }
    }
}
