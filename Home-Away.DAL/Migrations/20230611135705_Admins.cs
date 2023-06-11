using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Admins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_AdminId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_AdminId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

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
                name: "AdminId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AdminId",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2d3ae595-0c8d-4b64-8620-f5946941c34a", 0, "90ce21f7-bebc-4cde-88f0-9b8ce4f3a52d", new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin2@example.com", false, "Admin", "Female", new DateTime(2023, 6, 11, 13, 57, 4, 384, DateTimeKind.Utc).AddTicks(7370), "2", false, null, null, null, null, null, false, "ed5d9c9c-ddf1-44b4-b368-52f089cc6b20", false, "admin2@example.com" },
                    { "4f37d01f-23f2-4e95-aff7-7f49370e10af", 0, "ca5ce528-d441-45c3-8c40-b2d1d7747fc2", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin1@example.com", false, "Admin", "Male", new DateTime(2023, 6, 11, 13, 57, 4, 384, DateTimeKind.Utc).AddTicks(7330), "1", false, null, null, null, null, null, false, "f6cc8075-5348-447b-be6b-16199a630c29", false, "admin1@example.com" },
                    { "fa9cdeca-3940-4dce-b484-d8af5aee34ce", 0, "bffd0aea-8cbe-4d4d-a631-50ccb3bb37aa", new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin3@example.com", false, "Admin", "Male", new DateTime(2023, 6, 11, 13, 57, 4, 384, DateTimeKind.Utc).AddTicks(7390), "3", false, null, null, null, null, null, false, "76a0c23a-144f-4a92-8d83-f5dc06b854d2", false, "admin3@example.com" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_AdminId",
                table: "Reservations",
                column: "AdminId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_AdminId",
                table: "Reviews",
                column: "AdminId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_AdminId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_AdminId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d3ae595-0c8d-4b64-8620-f5946941c34a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f37d01f-23f2-4e95-aff7-7f49370e10af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa9cdeca-3940-4dce-b484-d8af5aee34ce");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Reviews",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "AdminId",
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
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "AdminId",
                table: "Reservations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AcountState", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "EntryDate", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Owner", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TotalMoneySpent", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "75ec08de-5d52-48ac-9630-128f64453791", 0, 0, "8baa9f71-f0d7-405e-a9ec-ec33964c7d97", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 16, 25, 58, 729, DateTimeKind.Local).AddTicks(9683), "Mike", "Male", "Johnson", false, null, null, null, 1, null, null, false, "path/to/profile-image.jpg", "b8a57637-4379-4af7-85cb-f85738732783", 750.25m, false, null },
                    { "b13dd2b9-8186-428b-bf9a-a0c1575a2f07", 0, 1, "5f589c71-9b69-44fe-a954-4cb06c46924e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 16, 25, 58, 729, DateTimeKind.Local).AddTicks(9657), "Jane", "Female", "Smith", false, null, null, null, 0, null, null, false, "path/to/profile-image.jpg", "137700aa-7c9c-40c3-bd45-4aacbde8de22", 1500.50m, false, null },
                    { "f333ab08-c827-4e6d-8c4f-ca58ed7160a4", 0, 1, "0347f9a4-bb0e-46d5-bb63-1119c9c22cd3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 16, 25, 58, 729, DateTimeKind.Local).AddTicks(9537), "John", "Male", "Doe", false, null, null, null, 1, null, null, false, "path/to/profile-image.jpg", "d418a509-7a91-4961-bf40-fb8b32dd19c2", 1000.00m, false, null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_AdminId",
                table: "Reservations",
                column: "AdminId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_UserId",
                table: "Reservations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_AdminId",
                table: "Reviews",
                column: "AdminId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
