using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updatesinPropfeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d4ebedb-266e-4788-8d8d-0deb045f27a6");

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
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 20, 0, 5, 30, 188, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Area", "DateOfAddingProperty", "Description", "Title", "Type" },
                values: new object[] { "Garden", new DateTime(2023, 6, 20, 0, 5, 30, 188, DateTimeKind.Local).AddTicks(5248), "A stunning Apartment with breathtaking views", "Fancy Apartment", "Apartment" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfAddingProperty", "Description", "Title", "Type" },
                values: new object[] { new DateTime(2023, 6, 20, 0, 5, 30, 188, DateTimeKind.Local).AddTicks(5259), "A stunning house with breathtaking views", "Luxurious House", "House" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfAddingProperty", "Description", "Title", "Type" },
                values: new object[] { new DateTime(2023, 6, 20, 0, 5, 30, 188, DateTimeKind.Local).AddTicks(5271), "A camp with breathtaking views", "A comfy camp", "Camp" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfAddingProperty", "Description", "Title", "Type" },
                values: new object[] { new DateTime(2023, 6, 20, 0, 5, 30, 188, DateTimeKind.Local).AddTicks(5286), "A stunning house with breathtaking views", "Luxurious house", "House" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "519a5f4b-ea81-4035-a8ee-dac820f64f68", new DateTime(2023, 6, 19, 22, 2, 20, 18, DateTimeKind.Local).AddTicks(2170), "db6f190d-be99-4f7a-b1ab-49163706f325" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b952",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "1dd587b5-e41b-42fd-9e45-17346eeb2c5c", new DateTime(2023, 6, 19, 22, 2, 20, 18, DateTimeKind.Local).AddTicks(2333), "b6995bc4-c96c-447f-9133-b21317b85754" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b953",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "4d6623aa-a391-4bde-965b-b14d4630db33", new DateTime(2023, 6, 19, 19, 2, 20, 25, DateTimeKind.Utc).AddTicks(6946), "51a9f0c2-d339-46d8-a93d-d7a9d2f801a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b954",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "SecurityStamp" },
                values: new object[] { "ce926132-4f4f-4f9b-a0d5-6baa38c4fe21", new DateTime(2023, 6, 19, 22, 2, 20, 18, DateTimeKind.Local).AddTicks(2380), "a9f8903b-5a87-4076-896b-1db6f4789bd8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbef741d-ad99-46cd-9e35-4f606638b955",
                columns: new[] { "ConcurrencyStamp", "HiringDate", "SecurityStamp" },
                values: new object[] { "811a6141-e9ef-4dbe-8ebe-5dca7b2cfbb7", new DateTime(2023, 6, 19, 19, 2, 20, 25, DateTimeKind.Utc).AddTicks(6988), "2d5c9834-d19a-4ef7-90ca-39a7dbbcf8f8" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Admin_DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "Admin_FirstName", "Admin_Gender", "HiringDate", "Admin_LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0d4ebedb-266e-4788-8d8d-0deb045f27a6", 0, "afe41546-140b-45e2-8b70-7bb3f650d266", new DateTime(1985, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "admin3@example.com", false, "Admin", "Male", new DateTime(2023, 6, 19, 19, 2, 20, 25, DateTimeKind.Utc).AddTicks(7194), "3", false, null, null, null, null, null, false, "66075ca9-7935-4cae-8e74-4b0fd9341894", false, "admin3@example.com" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfAddingProperty",
                value: new DateTime(2023, 6, 19, 22, 2, 20, 25, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Area", "DateOfAddingProperty", "Description", "Title", "Type" },
                values: new object[] { "Beachside", new DateTime(2023, 6, 19, 22, 2, 20, 25, DateTimeKind.Local).AddTicks(7402), "A stunning villa with breathtaking views", "Luxurious Villa", "Villa" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfAddingProperty", "Description", "Title", "Type" },
                values: new object[] { new DateTime(2023, 6, 19, 22, 2, 20, 25, DateTimeKind.Local).AddTicks(7417), "A stunning villa with breathtaking views", "Luxurious Villa", "Villa" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfAddingProperty", "Description", "Title", "Type" },
                values: new object[] { new DateTime(2023, 6, 19, 22, 2, 20, 25, DateTimeKind.Local).AddTicks(7427), "A stunning villa with breathtaking views", "Luxurious Villa", "Villa" });

            migrationBuilder.UpdateData(
                table: "Property",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfAddingProperty", "Description", "Title", "Type" },
                values: new object[] { new DateTime(2023, 6, 19, 22, 2, 20, 25, DateTimeKind.Local).AddTicks(7438), "A stunning villa with breathtaking views", "Luxurious Villa", "Villa" });
        }
    }
}
