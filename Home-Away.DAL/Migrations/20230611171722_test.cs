using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "206b05f6-5397-4912-ab75-580ad39eef21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29e67cec-cb1b-405f-a363-25e53bcbcd87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ccbb16f-a908-4ab9-be31-0c7aa7842135");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "428200e0-97b2-4195-a52f-e41f2c485236");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b9f4c2e-ee88-42fe-9a0c-67e2432065bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b953");

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
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
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
                columns: new[] { "Id", "AccessFailedCount", "AcountState", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "EntryDate", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Owner", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TotalMoneySpent", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "206b05f6-5397-4912-ab75-580ad39eef21", 0, 0, "d83a3070-04a1-46de-81cb-62be4382f3e9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 17, 2, 8, 385, DateTimeKind.Local).AddTicks(8326), "Mike", "Male", "Johnson", false, null, null, null, 1, null, null, false, "path/to/profile-image.jpg", "8755e1be-1f4f-4a69-b118-eb18ea364a9a", 750.25m, false, null },
                    { "29e67cec-cb1b-405f-a363-25e53bcbcd87", 0, 1, "095cf790-9eda-4c32-a0af-42c20051b638", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 17, 2, 8, 385, DateTimeKind.Local).AddTicks(8188), "John", "Male", "Doe", false, null, null, null, 1, null, null, false, "path/to/profile-image.jpg", "97340e33-8aeb-4330-b62d-ea5f7634e9bd", 1000.00m, false, null },
                    { "3ccbb16f-a908-4ab9-be31-0c7aa7842135", 0, 1, "04bf7714-428a-4ad3-9f7f-9e533b7a07f5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 11, 17, 2, 8, 385, DateTimeKind.Local).AddTicks(8304), "Jane", "Female", "Smith", false, null, null, null, 0, null, null, false, "path/to/profile-image.jpg", "e6101005-ddc3-4e81-a3ec-e30acdc9821c", 1500.50m, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "428200e0-97b2-4195-a52f-e41f2c485236", 0, "67bad422-0f9e-4955-b02a-7f5249c806c2", new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin3@example.com", false, "Admin", "Male", new DateTime(2023, 6, 11, 14, 2, 8, 385, DateTimeKind.Utc).AddTicks(9491), "3", false, null, null, null, null, null, false, "4cd6abf2-11fa-4fc4-bcae-76f81885c160", false, "admin3@example.com" },
                    { "4b9f4c2e-ee88-42fe-9a0c-67e2432065bc", 0, "e4de126f-2ce0-4ade-bd73-c6fb16cb1d8d", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin1@example.com", false, "Admin", "Male", new DateTime(2023, 6, 11, 14, 2, 8, 385, DateTimeKind.Utc).AddTicks(9292), "1", false, null, null, null, null, null, false, "237fa98a-79e4-4db3-ab63-0988f355a911", false, "admin1@example.com" },
                    { "fbef741d-ad99-46cd-9e35-4f606638b953", 0, "490ccd3d-b16c-4bd9-857c-01f3274b921c", new DateTime(1995, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin2@example.com", false, "Admin", "Female", new DateTime(2023, 6, 11, 14, 2, 8, 385, DateTimeKind.Utc).AddTicks(9315), "2", false, null, null, null, null, null, false, "0e7197c9-41ae-4a96-96dd-bc3e6edc658b", false, "admin2@example.com" }
                });

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
    }
}
