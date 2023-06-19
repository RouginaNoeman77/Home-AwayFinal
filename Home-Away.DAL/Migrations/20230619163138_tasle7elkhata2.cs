using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class tasle7elkhata2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDate",
                table: "Reviews",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestDate",
                table: "Reservations",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "Reservations",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFrom",
                table: "Reservations",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfAddingProperty",
                table: "Property",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 19, 31, 38, 259, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 19, 31, 38, 259, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 19, 31, 38, 259, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 19, 31, 38, 259, DateTimeKind.Local).AddTicks(4042));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RequestDate",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTo",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateFrom",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfAddingProperty",
                table: "Property",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

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
    }
}
