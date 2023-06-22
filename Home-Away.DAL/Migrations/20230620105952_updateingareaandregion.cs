using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateingareaandregion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4fec594-0d0d-48a6-8de6-8bf261729056");

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
                columns: new[] { "Area", "DateOfAddingProperty", "Region" },
                values: new object[] { "Beachfront", new DateTime(2023, 6, 20, 13, 59, 52, 187, DateTimeKind.Local).AddTicks(9856), "Tropical" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Area", "DateOfAddingProperty", "Region" },
                values: new object[] { "Seaside", new DateTime(2023, 6, 20, 13, 59, 52, 187, DateTimeKind.Local).AddTicks(9871), "Island" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Area", "DateOfAddingProperty", "Region" },
                values: new object[] { "Coastline", new DateTime(2023, 6, 20, 13, 59, 52, 187, DateTimeKind.Local).AddTicks(9883), "Mediterranean" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Area", "DateOfAddingProperty", "Region" },
                values: new object[] { "Remote Beach", new DateTime(2023, 6, 20, 13, 59, 52, 187, DateTimeKind.Local).AddTicks(9895), "Secluded" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "d2a571d8-2200-4897-96d9-f11797bc2f40", new DateTime(2023, 6, 20, 12, 35, 16, 525, DateTimeKind.Local).AddTicks(838), "93ea77e5-36f6-4851-82fd-b5a63bd4a5da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b952",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "f7a588d6-981b-45c8-b50a-a5085da5f72b", new DateTime(2023, 6, 20, 12, 35, 16, 525, DateTimeKind.Local).AddTicks(949), "bb82b95c-9067-4584-bd0c-7d5e7ff554cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b953",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "e7a62dd2-7c01-444e-9260-7f8ab5134835", new DateTime(2023, 6, 20, 9, 35, 16, 529, DateTimeKind.Utc).AddTicks(5885), "9a095be1-4b0f-4f07-bf93-abb8a3665c3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b954",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "bfea1bb0-47e9-43f6-9e17-4968d9fe90cf", new DateTime(2023, 6, 20, 12, 35, 16, 525, DateTimeKind.Local).AddTicks(974), "da1a4dd8-2799-4471-9cad-1f1d73765c47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b955",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "fa5eb46e-1446-459d-a810-3a9074e59db6", new DateTime(2023, 6, 20, 9, 35, 16, 529, DateTimeKind.Utc).AddTicks(5908), "a6f325d9-485f-4df2-b502-c859ae60aa1d" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e4fec594-0d0d-48a6-8de6-8bf261729056", 0, "61f9be7f-e7f2-4738-a119-8529283eaa5f", new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin3@example.com", false, "Admin", "Male", new DateTime(2023, 6, 20, 9, 35, 16, 529, DateTimeKind.Utc).AddTicks(5945), "3", false, null, null, null, null, null, false, "d9bc6925-29e4-49b7-abc7-0f782ad2ba44", false, "admin3@example.com" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 12, 35, 16, 529, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Area", "DateOfAddingProperty", "Region" },
                values: new object[] { "Garden", new DateTime(2023, 6, 20, 12, 35, 16, 529, DateTimeKind.Local).AddTicks(6055), "Coastal" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Area", "DateOfAddingProperty", "Region" },
                values: new object[] { "Beachside", new DateTime(2023, 6, 20, 12, 35, 16, 529, DateTimeKind.Local).AddTicks(6067), "Coastal" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Area", "DateOfAddingProperty", "Region" },
                values: new object[] { "Beachside", new DateTime(2023, 6, 20, 12, 35, 16, 529, DateTimeKind.Local).AddTicks(6076), "Coastal" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Area", "DateOfAddingProperty", "Region" },
                values: new object[] { "Beachside", new DateTime(2023, 6, 20, 12, 35, 16, 529, DateTimeKind.Local).AddTicks(6087), "Coastal" });
        }
    }
}
