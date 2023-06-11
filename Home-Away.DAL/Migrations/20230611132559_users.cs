using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a2d87aa-1893-42a8-98c5-826502ae03fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8105726f-d80f-42db-a854-cb9a3c1a0bc0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f379ac0e-6541-4fb6-83e2-0627c5f6e6ed");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AcountState", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "EntryDate", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Owner", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TotalMoneySpent", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "75ec08de-5d52-48ac-9630-128f64453791", 0, 0, "8baa9f71-f0d7-405e-a9ec-ec33964c7d97", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 16, 25, 58, 729, DateTimeKind.Local).AddTicks(9683), "Mike", "Male", "Johnson", false, null, null, null, 1, null, null, false, "path/to/profile-image.jpg", "b8a57637-4379-4af7-85cb-f85738732783", 750.25m, false, null },
                    { "b13dd2b9-8186-428b-bf9a-a0c1575a2f07", 0, 1, "5f589c71-9b69-44fe-a954-4cb06c46924e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 16, 25, 58, 729, DateTimeKind.Local).AddTicks(9657), "Jane", "Female", "Smith", false, null, null, null, 0, null, null, false, "path/to/profile-image.jpg", "137700aa-7c9c-40c3-bd45-4aacbde8de22", 1500.50m, false, null },
                    { "f333ab08-c827-4e6d-8c4f-ca58ed7160a4", 0, 1, "0347f9a4-bb0e-46d5-bb63-1119c9c22cd3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 16, 25, 58, 729, DateTimeKind.Local).AddTicks(9537), "John", "Male", "Doe", false, null, null, null, 1, null, null, false, "path/to/profile-image.jpg", "d418a509-7a91-4961-bf40-fb8b32dd19c2", 1000.00m, false, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75ec08de-5d52-48ac-9630-128f64453791");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b13dd2b9-8186-428b-bf9a-a0c1575a2f07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f333ab08-c827-4e6d-8c4f-ca58ed7160a4");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AcountState", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "EntryDate", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Owner", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TotalMoneySpent", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a2d87aa-1893-42a8-98c5-826502ae03fb", 0, 1, "787cb8ef-3d8d-43de-b1bc-103a9218b88b", new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 1, 35, 38, 62, DateTimeKind.Local).AddTicks(6359), "Jane", "Female", "Smith", false, null, null, null, 0, null, null, false, "path/to/profile-image.jpg", "0e949311-36a1-4b04-9b1a-6047cb1b4a7d", 1500.50m, false, null },
                    { "8105726f-d80f-42db-a854-cb9a3c1a0bc0", 0, 0, "38111d83-d2b2-4ddd-b16c-c8d460ffa646", new DateTime(1985, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 1, 35, 38, 62, DateTimeKind.Local).AddTicks(6376), "Mike", "Male", "Johnson", false, null, null, null, 1, null, null, false, "path/to/profile-image.jpg", "0a4ee448-2a18-4cb9-8ea0-6bae8498615d", 750.25m, false, null },
                    { "f379ac0e-6541-4fb6-83e2-0627c5f6e6ed", 0, 1, "23c71d01-fede-470c-b61a-131b3280e7cc", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 1, 35, 38, 62, DateTimeKind.Local).AddTicks(6292), "John", "Male", "Doe", false, null, null, null, 1, null, null, false, "path/to/profile-image.jpg", "f64729b4-178a-4767-b418-068b9770770d", 1000.00m, false, null }
                });
        }
    }
}
