using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NourhanSeeding : Migration
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
                values: new object[] { "e6a8a2d0-7417-402d-88d4-47adcda58d63", new DateTime(2023, 6, 13, 19, 53, 43, 314, DateTimeKind.Local).AddTicks(8442), "a8f77440-4a69-4dc4-9c77-d0568dbb452e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b952",
                columns: new[] { "ConcurrencyStamp", "EntryDate", "SecurityStamp" },
                values: new object[] { "2f0626d2-b649-44a3-a112-1e2bca2b9d30", new DateTime(2023, 6, 13, 19, 53, 43, 314, DateTimeKind.Local).AddTicks(8958), "61a13f11-b42f-4a5d-bbb0-cdec876a4971" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b953",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "d66c2db7-43d8-45df-8c1c-5c78a636a64a", new DateTime(2023, 6, 13, 16, 53, 43, 337, DateTimeKind.Utc).AddTicks(3449), "7b2d0710-8a75-4513-adb4-68a41dec8d10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b954",
                columns: new[] { "ConcurrencyStamp", "EntryDate", "SecurityStamp" },
                values: new object[] { "6c2ee0aa-8bde-4b4a-9755-0cde8d47411a", new DateTime(2023, 6, 13, 19, 53, 43, 314, DateTimeKind.Local).AddTicks(9032), "0968d791-3ae7-4ac4-99ab-83cdfd63b614" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b955",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "21166ced-ca9e-4d71-b603-e34221a9d697", new DateTime(2023, 6, 13, 16, 53, 43, 337, DateTimeKind.Utc).AddTicks(3522), "733f146f-07f6-4399-87e4-506986c5f814" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5b345e6f-ca40-43ae-a443-ad1a2f98c6bd", 0, "5f6309b7-bf3f-485c-8a5c-1ef6fc130d0e", new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin3@example.com", false, "Admin", "Male", new DateTime(2023, 6, 13, 16, 53, 43, 337, DateTimeKind.Utc).AddTicks(3560), "3", false, null, null, null, null, null, false, "c66fb172-8b63-413e-a3bc-36580004f469", false, "admin3@example.com" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 13, 19, 53, 43, 337, DateTimeKind.Local).AddTicks(3723));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b345e6f-ca40-43ae-a443-ad1a2f98c6bd");

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
