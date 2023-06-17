using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class testapi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6572b01-b8a8-4aa3-949f-06940064e74b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b951",
                columns: new[] { "ConcurrencyStamp", "EntryDate", "SecurityStamp" },
                values: new object[] { "72628f89-adb2-41e4-9792-42ce47e1faf1", new DateTime(2023, 6, 13, 13, 34, 14, 234, DateTimeKind.Local).AddTicks(8513), "a5dadfd6-350e-48c3-92ee-ddc03878e2f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b952",
                columns: new[] { "ConcurrencyStamp", "EntryDate", "SecurityStamp" },
                values: new object[] { "dea42656-aba4-49c4-b859-a6b1310a2306", new DateTime(2023, 6, 13, 13, 34, 14, 234, DateTimeKind.Local).AddTicks(8585), "4ae7b955-1b83-4ff2-ac74-e2a970737f87" });

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
                columns: new[] { "ConcurrencyStamp", "EntryDate", "SecurityStamp" },
                values: new object[] { "d8ed290f-97c8-4b64-812e-e5192501f358", new DateTime(2023, 6, 13, 13, 34, 14, 234, DateTimeKind.Local).AddTicks(8595), "eef21c6b-82c3-48f8-adc2-bff48e47fe79" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e424841-b6f8-4a08-b8f1-f21239545362");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b951",
                columns: new[] { "ConcurrencyStamp", "EntryDate", "SecurityStamp" },
                values: new object[] { "b48a58c1-ea1e-43f3-9572-833fb95ac092", new DateTime(2023, 6, 11, 20, 34, 45, 233, DateTimeKind.Local).AddTicks(5955), "9931d898-05d7-4220-bee5-f895b8be0ca2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b952",
                columns: new[] { "ConcurrencyStamp", "EntryDate", "SecurityStamp" },
                values: new object[] { "a4419425-c8ea-4056-a2bf-22e8f8a31e25", new DateTime(2023, 6, 11, 20, 34, 45, 233, DateTimeKind.Local).AddTicks(6041), "48f96a76-1dc0-421c-918c-e3c928e90eac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b953",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "f3bce41f-72e2-47f0-8da4-3f1e8879dc0c", new DateTime(2023, 6, 11, 17, 34, 45, 233, DateTimeKind.Utc).AddTicks(6935), "8eb5debf-b05a-4069-946e-e6f55235b715" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b954",
                columns: new[] { "ConcurrencyStamp", "EntryDate", "SecurityStamp" },
                values: new object[] { "a22a5893-6090-4122-ac19-440cda6f2898", new DateTime(2023, 6, 11, 20, 34, 45, 233, DateTimeKind.Local).AddTicks(6065), "db9489f9-b5ab-4559-ad07-c5e3cb327310" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b955",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "7eefa878-317c-4230-aa24-8e97a61b16e2", new DateTime(2023, 6, 11, 17, 34, 45, 233, DateTimeKind.Utc).AddTicks(6955), "f011244c-41ab-49ec-a6af-9c53c18033df" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f6572b01-b8a8-4aa3-949f-06940064e74b", 0, "f9f5b3ee-a614-4c3d-9a04-920d111971a1", new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin3@example.com", false, "Admin", "Male", new DateTime(2023, 6, 11, 17, 34, 45, 233, DateTimeKind.Utc).AddTicks(6980), "3", false, null, null, null, null, null, false, "cb3488d7-0538-4bdd-82a9-f526837cbeae", false, "admin3@example.com" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 11, 20, 34, 45, 233, DateTimeKind.Local).AddTicks(7044));
        }
    }
}
