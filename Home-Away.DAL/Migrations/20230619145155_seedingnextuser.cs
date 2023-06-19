using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class seedingnextuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e424841-b6f8-4a08-b8f1-f21239545362");

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
                columns: new[] { "AcountState", "ConcurrencyStamp", "EntryDate", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { 0, "79a1e0b4-a339-4b19-b112-7c4cbc2e1ba7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "password123", "fa17719e-0b0c-426a-a9ec-3898edaf9002", "johndoe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b952",
                columns: new[] { "AcountState", "ConcurrencyStamp", "EntryDate", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { 0, "a55f5d58-5cc5-43b3-94a1-a45bf64ad99f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "pass456", "a5ddb21d-c931-416c-abb2-258f940dc71a", "janesmith" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b953",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "0f3dd34e-86c9-472a-be28-b1a381b10da1", new DateTime(2023, 6, 19, 14, 51, 55, 321, DateTimeKind.Utc).AddTicks(9059), "5c22229d-d4d0-4800-ad65-cf3e7fb55032" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b954",
                columns: new[] { "ConcurrencyStamp", "EntryDate", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8b458532-a4ee-473b-a565-074febeea263", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mysecretpass", "8d94575a-5361-491c-8ebb-aeaeca31cd12", "mikejohn" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b955",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "9b71af61-3c40-4a72-bd90-f8dab2b187a9", new DateTime(2023, 6, 19, 14, 51, 55, 321, DateTimeKind.Utc).AddTicks(9089), "52ce872d-4f26-4a96-bc17-a819c25c3c9f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AcountState", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "EntryDate", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Owner", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TotalMoneySpent", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2ade7947-5279-4e67-b3ec-6d1713c3a49b", 0, 0, "4350a058-2dc0-4999-a4eb-b05f8b131423", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 19, 14, 51, 55, 313, DateTimeKind.Utc).AddTicks(7658), "Michael", "Male", "Smith", false, null, null, null, 0, "pass123", null, false, "path/to/profile-image.jpg", "2c065b7f-a9d2-46c3-9aea-4a377b78b01e", 600.75m, false, "michaelsmith" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "413c5cf4-ba4f-45fe-8fc3-fba3983be210", 0, "85e3436b-a3ec-487d-9f2a-b52a4c6a336c", new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin5@example.com", false, "Admin", "Female", new DateTime(2023, 6, 19, 14, 51, 55, 321, DateTimeKind.Utc).AddTicks(9249), "5", false, null, null, null, null, null, false, "ede36eb5-1b50-4839-b50a-08cbf1a68c76", false, "admin5@example.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AcountState", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "EntryDate", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Owner", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TotalMoneySpent", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "48665ad6-de32-46c9-843e-97e42a1f49ae", 0, 0, "68718d1d-8dba-45d1-9966-f2ecd1c12a71", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 19, 14, 51, 55, 313, DateTimeKind.Utc).AddTicks(7642), "Sophia", "Female", "Clark", false, null, null, null, 1, "password321", null, false, "path/to/profile-image.jpg", "25817af4-f65a-4d38-a574-6fd93dd25381", 1200.00m, false, "sophiaclark" },
                    { "489ce88b-026c-4b20-9c8b-8dd897b3707a", 0, 0, "32820f2b-0eca-4280-9069-96ace307a591", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 19, 14, 51, 55, 313, DateTimeKind.Utc).AddTicks(7562), "David", "Male", "Brown", false, null, null, null, 1, "p@ssword", null, false, "path/to/profile-image.jpg", "5eb8642e-d12c-46dc-9c01-3031ef87dcc2", 950.25m, false, "davidbrown" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5845073f-60bd-4996-afc0-17dc02d52750", 0, "af827322-4d17-4225-98e9-d473fb527091", new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin3@example.com", false, "Admin", "Male", new DateTime(2023, 6, 19, 14, 51, 55, 321, DateTimeKind.Utc).AddTicks(9114), "3", false, null, null, null, null, null, false, "8ce8421d-a242-47a5-9944-ceb216f73b4a", false, "admin3@example.com" },
                    { "7c35a0d9-5f65-4274-ad98-9741489bd6e8", 0, "f7b38df3-997d-4a39-b4e4-d7a9dff50a82", new DateTime(1992, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin4@example.com", false, "Admin", "Male", new DateTime(2023, 6, 19, 14, 51, 55, 321, DateTimeKind.Utc).AddTicks(9126), "4", false, null, null, null, null, null, false, "a52ea515-c531-48d5-b22b-157f84c6a993", false, "admin4@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AcountState", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "EntryDate", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Owner", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfileImage", "SecurityStamp", "TotalMoneySpent", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e46e55da-d8b1-4e40-826f-5dca3424eb05", 0, 0, "5ff5ef1b-642a-4a2d-a638-634ef659264f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null, false, new DateTime(2023, 6, 19, 14, 51, 55, 313, DateTimeKind.Utc).AddTicks(7543), "Emily", "Female", "Anderson", false, null, null, null, 0, "pass789", null, false, "path/to/profile-image.jpg", "9207f79e-ece8-4f09-ac08-1c18ee7231e8", 800.50m, false, "emilyand" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e6f12e7d-f393-4990-a6f6-ae8ffc1f4f12", 0, "b004ee6e-b014-48ca-8fb9-3631f7e1e647", new DateTime(1993, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin6@example.com", false, "Admin", "Male", new DateTime(2023, 6, 19, 14, 51, 55, 321, DateTimeKind.Utc).AddTicks(9262), "6", false, null, null, null, null, null, false, "9edd476d-c67f-486b-ae20-9fcca22d641f", false, "admin6@example.com" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 17, 51, 55, 321, DateTimeKind.Local).AddTicks(9380));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ade7947-5279-4e67-b3ec-6d1713c3a49b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413c5cf4-ba4f-45fe-8fc3-fba3983be210");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48665ad6-de32-46c9-843e-97e42a1f49ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "489ce88b-026c-4b20-9c8b-8dd897b3707a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5845073f-60bd-4996-afc0-17dc02d52750");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c35a0d9-5f65-4274-ad98-9741489bd6e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e46e55da-d8b1-4e40-826f-5dca3424eb05");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6f12e7d-f393-4990-a6f6-ae8ffc1f4f12");

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
                columns: new[] { "AcountState", "ConcurrencyStamp", "EntryDate", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { 1, "72628f89-adb2-41e4-9792-42ce47e1faf1", new DateTime(2023, 6, 13, 13, 34, 14, 234, DateTimeKind.Local).AddTicks(8513), null, "a5dadfd6-350e-48c3-92ee-ddc03878e2f3", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b952",
                columns: new[] { "AcountState", "ConcurrencyStamp", "EntryDate", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { 1, "dea42656-aba4-49c4-b859-a6b1310a2306", new DateTime(2023, 6, 13, 13, 34, 14, 234, DateTimeKind.Local).AddTicks(8585), null, "4ae7b955-1b83-4ff2-ac74-e2a970737f87", null });

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
                columns: new[] { "ConcurrencyStamp", "EntryDate", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d8ed290f-97c8-4b64-812e-e5192501f358", new DateTime(2023, 6, 13, 13, 34, 14, 234, DateTimeKind.Local).AddTicks(8595), null, "eef21c6b-82c3-48f8-adc2-bff48e47fe79", null });

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
