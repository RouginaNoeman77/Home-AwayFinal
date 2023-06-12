using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Propertyseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f6572b01-b8a8-4aa3-949f-06940064e74b", 0, "f9f5b3ee-a614-4c3d-9a04-920d111971a1", new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin3@example.com", false, "Admin", "Male", new DateTime(2023, 6, 11, 17, 34, 45, 233, DateTimeKind.Utc).AddTicks(6980), "3", false, null, null, null, null, null, false, "cb3488d7-0538-4bdd-82a9-f526837cbeae", false, "admin3@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AcountState", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "EntryDate", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Owner", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TotalMoneySpent", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fbef741d-ad99-46cd-9e35-4f606638b951", 0, 1, "b48a58c1-ea1e-43f3-9572-833fb95ac092", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 20, 34, 45, 233, DateTimeKind.Local).AddTicks(5955), "John", "Male", "Doe", false, null, null, null, 1, null, null, false, "path/to/profile-image.jpg", "9931d898-05d7-4220-bee5-f895b8be0ca2", 1000.00m, false, null },
                    { "fbef741d-ad99-46cd-9e35-4f606638b952", 0, 1, "a4419425-c8ea-4056-a2bf-22e8f8a31e25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 20, 34, 45, 233, DateTimeKind.Local).AddTicks(6041), "Jane", "Female", "Smith", false, null, null, null, 0, null, null, false, "path/to/profile-image.jpg", "48f96a76-1dc0-421c-918c-e3c928e90eac", 1500.50m, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fbef741d-ad99-46cd-9e35-4f606638b953", 0, "f3bce41f-72e2-47f0-8da4-3f1e8879dc0c", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin1@example.com", false, "Admin", "Male", new DateTime(2023, 6, 11, 17, 34, 45, 233, DateTimeKind.Utc).AddTicks(6935), "1", false, null, null, null, null, null, false, "8eb5debf-b05a-4069-946e-e6f55235b715", false, "admin1@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AcountState", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "EntryDate", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Owner", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TotalMoneySpent", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fbef741d-ad99-46cd-9e35-4f606638b954", 0, 0, "a22a5893-6090-4122-ac19-440cda6f2898", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 20, 34, 45, 233, DateTimeKind.Local).AddTicks(6065), "Mike", "Male", "Johnson", false, null, null, null, 1, null, null, false, "path/to/profile-image.jpg", "db9489f9-b5ab-4559-ad07-c5e3cb327310", 750.25m, false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fbef741d-ad99-46cd-9e35-4f606638b955", 0, "7eefa878-317c-4230-aa24-8e97a61b16e2", new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin2@example.com", false, "Admin", "Female", new DateTime(2023, 6, 11, 17, 34, 45, 233, DateTimeKind.Utc).AddTicks(6955), "2", false, null, null, null, null, null, false, "f011244c-41ab-49ec-a6af-9c53c18033df", false, "admin2@example.com" });

            migrationBuilder.InsertData(
                table: "Property",
                columns: new[] { "Id", "Address", "AdminId", "Area", "AverageRating", "Capacity", "Category", "DateOfAddingProperty", "Description", "NumberOfBathrooms", "NumberOfFloors", "NumberOfRooms", "OwnerId", "PricePerNight", "Region", "State", "Title", "Type" },
                values: new object[] { 1, "123 Main Street", "fbef741d-ad99-46cd-9e35-4f606638b953", "Beachside", 4.5m, 8, "Vacation Rental", new DateTime(2023, 6, 11, 20, 34, 45, 233, DateTimeKind.Local).AddTicks(7044), "A stunning villa with breathtaking views", 3, 2, 4, "fbef741d-ad99-46cd-9e35-4f606638b954", 500.00m, "Coastal", "Pending", "Luxurious Villa", "Villa" });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6572b01-b8a8-4aa3-949f-06940064e74b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b951");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b952");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b955");

            migrationBuilder.DeleteData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b953");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b954");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
