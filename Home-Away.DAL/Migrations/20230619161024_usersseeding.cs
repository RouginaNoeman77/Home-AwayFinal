using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class usersseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e424841-b6f8-4a08-b8f1-f21239545362");

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "AspNetUsers",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EntryDate",
                table: "AspNetUsers",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Admin_DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b951",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "EntryDate", "SecurityStamp" },
                values: new object[] { "b98e4f08-6a06-4f85-a373-b51621000100", new DateTime(2023, 6, 19, 19, 10, 24, 476, DateTimeKind.Local).AddTicks(4901), new DateTime(2023, 6, 19, 19, 10, 24, 476, DateTimeKind.Local).AddTicks(4970), "cca79a19-5625-479c-a533-4344a27692e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b952",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "EntryDate", "SecurityStamp" },
                values: new object[] { "6c25ce81-63b5-4b80-ae6c-46fe197f584d", new DateTime(2023, 6, 19, 19, 10, 24, 476, DateTimeKind.Local).AddTicks(5044), new DateTime(2023, 6, 19, 19, 10, 24, 476, DateTimeKind.Local).AddTicks(5046), "3b910a44-9351-48be-b28e-f518dcbabd4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b953",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "177730b0-9466-435b-895b-5e7668e6d2a1", new DateTime(2023, 6, 19, 16, 10, 24, 481, DateTimeKind.Utc).AddTicks(443), "b21fbb16-5b7a-4e15-8be8-31268f5eda8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b954",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "EntryDate", "SecurityStamp" },
                values: new object[] { "66181e1c-1fbe-4aec-a33c-a038b638327a", new DateTime(2023, 6, 19, 19, 10, 24, 476, DateTimeKind.Local).AddTicks(5183), new DateTime(2023, 6, 19, 19, 10, 24, 476, DateTimeKind.Local).AddTicks(5186), "6a42ac52-9c6f-4f5b-9c68-e27d29fbada8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b955",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "ad9a1b27-773e-4ed1-b35e-ad8b3f9351be", new DateTime(2023, 6, 19, 16, 10, 24, 481, DateTimeKind.Utc).AddTicks(484), "332d7481-3f39-4fab-8c3a-80f68b36da93" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0ea9ca30-f52d-4a86-b2c8-ab83b2ce188c", 0, "1c7c89fc-93e4-4e40-95fc-3074ff12d379", new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin3@example.com", false, "Admin", "Male", new DateTime(2023, 6, 19, 16, 10, 24, 481, DateTimeKind.Utc).AddTicks(510), "3", false, null, null, null, null, null, false, "f9253601-c7db-4954-89f3-8b2d45fb4f5f", false, "admin3@example.com" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 19, 10, 24, 481, DateTimeKind.Local).AddTicks(596));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ea9ca30-f52d-4a86-b2c8-ab83b2ce188c");

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

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EntryDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Admin_DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b951",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "EntryDate", "SecurityStamp" },
                values: new object[] { "72628f89-adb2-41e4-9792-42ce47e1faf1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 13, 13, 34, 14, 234, DateTimeKind.Local).AddTicks(8513), "a5dadfd6-350e-48c3-92ee-ddc03878e2f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b952",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "EntryDate", "SecurityStamp" },
                values: new object[] { "dea42656-aba4-49c4-b859-a6b1310a2306", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 13, 13, 34, 14, 234, DateTimeKind.Local).AddTicks(8585), "4ae7b955-1b83-4ff2-ac74-e2a970737f87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b953",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "a6267720-ce29-402f-aad7-b78b381df7eb", new DateTime(2023, 6, 13, 10, 34, 14, 237, DateTimeKind.Utc).AddTicks(3578), "7bd55909-3840-4c46-9eef-a27e73cd1dbc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b954",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "EntryDate", "SecurityStamp" },
                values: new object[] { "d8ed290f-97c8-4b64-812e-e5192501f358", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 13, 13, 34, 14, 234, DateTimeKind.Local).AddTicks(8595), "eef21c6b-82c3-48f8-adc2-bff48e47fe79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b955",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "b98bb1c2-f37d-41f4-8126-504aeae806af", new DateTime(2023, 6, 13, 10, 34, 14, 237, DateTimeKind.Utc).AddTicks(3590), "c375a3df-892a-491f-9cb6-bcb901d4ace7" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8e424841-b6f8-4a08-b8f1-f21239545362", 0, "b7e2afcc-0d43-4685-9b3a-91ac247e0554", new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin3@example.com", false, "Admin", "Male", new DateTime(2023, 6, 13, 10, 34, 14, 237, DateTimeKind.Utc).AddTicks(3607), "3", false, null, null, null, null, null, false, "847aac65-d1c4-44dd-80f9-d6932bbcbb93", false, "admin3@example.com" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 13, 13, 34, 14, 237, DateTimeKind.Local).AddTicks(3653));
        }
    }
}
