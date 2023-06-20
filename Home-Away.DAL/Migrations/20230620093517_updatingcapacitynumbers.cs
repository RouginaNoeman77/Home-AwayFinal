using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updatingcapacitynumbers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6efce695-3910-4c41-a2cc-5530d1775102");

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
                columns: new[] { "Capacity", "DateOfAddingProperty" },
                values: new object[] { 20, new DateTime(2023, 6, 20, 12, 35, 16, 529, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 12, 35, 16, 529, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "DateOfAddingProperty" },
                values: new object[] { 10, new DateTime(2023, 6, 20, 12, 35, 16, 529, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "DateOfAddingProperty" },
                values: new object[] { 4, new DateTime(2023, 6, 20, 12, 35, 16, 529, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "DateOfAddingProperty" },
                values: new object[] { 15, new DateTime(2023, 6, 20, 12, 35, 16, 529, DateTimeKind.Local).AddTicks(6087) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3208d198-9d6b-446b-b8ff-46139e0e6ebc", new DateTime(2023, 6, 20, 0, 5, 30, 180, DateTimeKind.Local).AddTicks(2906), "61d06df6-13cc-4c7e-aa42-1a011c480a2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b952",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "d1701b15-3a58-41e7-ac47-32022588d19f", new DateTime(2023, 6, 20, 0, 5, 30, 180, DateTimeKind.Local).AddTicks(3092), "a0400faf-9520-4e58-a24f-dbe2cff7895b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b953",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "377d04b9-1915-42d8-9a99-5719db25b5c3", new DateTime(2023, 6, 19, 21, 5, 30, 188, DateTimeKind.Utc).AddTicks(5000), "35e034b7-f32c-4bfb-9b27-30a7e3089c58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b954",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "b7da4d64-9945-4647-8992-04e634448205", new DateTime(2023, 6, 20, 0, 5, 30, 180, DateTimeKind.Local).AddTicks(3160), "04d01119-1f27-419c-95fd-5b3878bc19b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b955",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "ba2694c6-63dc-4725-87a2-f39ad6fce1ed", new DateTime(2023, 6, 19, 21, 5, 30, 188, DateTimeKind.Utc).AddTicks(5027), "be103e06-c0df-464c-a94e-0dde902f3c29" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6efce695-3910-4c41-a2cc-5530d1775102", 0, "e9bea716-bc0f-4f54-885d-704c6b95f620", new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin3@example.com", false, "Admin", "Male", new DateTime(2023, 6, 19, 21, 5, 30, 188, DateTimeKind.Utc).AddTicks(5067), "3", false, null, null, null, null, null, false, "0f697a3b-b68d-43fe-8994-657387a116ec", false, "admin3@example.com" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Capacity", "DateOfAddingProperty" },
                values: new object[] { 8, new DateTime(2023, 6, 20, 0, 5, 30, 188, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 0, 5, 30, 188, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Capacity", "DateOfAddingProperty" },
                values: new object[] { 8, new DateTime(2023, 6, 20, 0, 5, 30, 188, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Capacity", "DateOfAddingProperty" },
                values: new object[] { 8, new DateTime(2023, 6, 20, 0, 5, 30, 188, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Capacity", "DateOfAddingProperty" },
                values: new object[] { 8, new DateTime(2023, 6, 20, 0, 5, 30, 188, DateTimeKind.Local).AddTicks(5286) });
        }
    }
}
