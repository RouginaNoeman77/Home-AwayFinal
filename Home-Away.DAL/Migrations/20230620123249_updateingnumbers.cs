using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateingnumbers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20a1f6af-af19-422a-ba8f-f87b092db263");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b951",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "8ef5efcc-ba96-46e0-b4ee-7abc3930a649", new DateTime(2023, 6, 20, 15, 32, 48, 577, DateTimeKind.Local).AddTicks(7656), "9df757ea-b76f-4856-9cd1-0377cc970923" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b952",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "04e7c953-871e-4aef-bc07-91e719f99295", new DateTime(2023, 6, 20, 15, 32, 48, 577, DateTimeKind.Local).AddTicks(7820), "39a7a8e6-8578-419f-b8e2-f31f3f6a5d5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b953",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "d5565347-93d6-4a10-9c0e-b3cdf4dce479", new DateTime(2023, 6, 20, 12, 32, 48, 585, DateTimeKind.Utc).AddTicks(4990), "3dc49e09-6b04-4f58-bbeb-fbf6c24f83a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b954",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "1cb8b3c2-261a-4eb6-9c4a-4df5955fac7c", new DateTime(2023, 6, 20, 15, 32, 48, 577, DateTimeKind.Local).AddTicks(7846), "eeed86e7-7f54-41cf-94d8-6f2ebddad0b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b955",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "9d9f4681-0cc9-45d9-8b1b-a66314400dda", new DateTime(2023, 6, 20, 12, 32, 48, 585, DateTimeKind.Utc).AddTicks(5014), "331d7ba2-695f-4996-9075-fe910b4e87c9" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f40bca14-8d06-428b-9bb3-04e2e0b780fc", 0, "f9aafffe-9614-47c0-8c4f-963ba31f5509", new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin3@example.com", false, "Admin", "Male", new DateTime(2023, 6, 20, 12, 32, 48, 585, DateTimeKind.Utc).AddTicks(5035), "3", false, null, null, null, null, null, false, "29c6c289-86e9-4a22-b3cb-181d03775a85", false, "admin3@example.com" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 15, 32, 48, 585, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 15, 32, 48, 585, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 15, 32, 48, 585, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 15, 32, 48, 585, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 15, 32, 48, 585, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.InsertData(
                table: "Property",
                columns: new[] { "Id", "Address", "AdminId", "Area", "AverageRating", "Capacity", "Category", "DateOfAddingProperty", "Description", "NumberOfBathrooms", "NumberOfFloors", "NumberOfRooms", "OwnerId", "PricePerNight", "Region", "State", "Title", "Type" },
                values: new object[,]
                {
                    { 6, "123 Main Street", "fbef741d-ad99-46cd-9e35-4f606638b953", "Seaside", 4.5m, 20, "Vacation Rental", new DateTime(2023, 6, 20, 15, 32, 48, 585, DateTimeKind.Local).AddTicks(5174), "A stunning house with breathtaking views", 3, 2, 4, "fbef741d-ad99-46cd-9e35-4f606638b954", 500.00m, "Island", "Pending", "Luxurious House", "House" },
                    { 7, "123 Main Street", "fbef741d-ad99-46cd-9e35-4f606638b953", "Seaside", 4.5m, 5, "Vacation Rental", new DateTime(2023, 6, 20, 15, 32, 48, 585, DateTimeKind.Local).AddTicks(5185), "A stunning house with breathtaking views", 3, 2, 4, "fbef741d-ad99-46cd-9e35-4f606638b954", 500.00m, "Island", "Pending", "Luxurious House", "House" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f40bca14-8d06-428b-9bb3-04e2e0b780fc");

            migrationBuilder.DeleteData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b951",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "9521ad0c-b758-4d44-bf21-791724d04954", new DateTime(2023, 6, 20, 13, 59, 52, 180, DateTimeKind.Local).AddTicks(1273), "e32cd356-5504-4084-818a-6717473194d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b952",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "ee90b85a-36a0-4f81-972d-f53919da8a6a", new DateTime(2023, 6, 20, 13, 59, 52, 180, DateTimeKind.Local).AddTicks(1516), "d4fd9d10-e92e-4c1b-ad48-6909cc4307e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b953",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "6a92d9f4-18e3-4958-a41e-2fb0ad8ab15b", new DateTime(2023, 6, 20, 10, 59, 52, 187, DateTimeKind.Utc).AddTicks(9621), "fa94f8d5-5bf1-4687-986e-70688e600ca6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b954",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "e74bcd20-f392-4415-93e1-36af4f3ddc32", new DateTime(2023, 6, 20, 13, 59, 52, 180, DateTimeKind.Local).AddTicks(1615), "311093da-964a-414c-9908-d02f9256103e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b955",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "4f7347c4-a10f-4c45-b652-5eff4d03d059", new DateTime(2023, 6, 20, 10, 59, 52, 187, DateTimeKind.Utc).AddTicks(9657), "05f3cc9d-8cb1-4702-8630-c55905b8fd3f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "20a1f6af-af19-422a-ba8f-f87b092db263", 0, "154d34cf-84b5-417a-a481-30acd5aed4d3", new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin3@example.com", false, "Admin", "Male", new DateTime(2023, 6, 20, 10, 59, 52, 187, DateTimeKind.Utc).AddTicks(9700), "3", false, null, null, null, null, null, false, "85f4a77e-5b1f-4911-8fa6-00a7d5b73547", false, "admin3@example.com" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 13, 59, 52, 187, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 13, 59, 52, 187, DateTimeKind.Local).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 13, 59, 52, 187, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 13, 59, 52, 187, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 13, 59, 52, 187, DateTimeKind.Local).AddTicks(9895));
        }
    }
}
