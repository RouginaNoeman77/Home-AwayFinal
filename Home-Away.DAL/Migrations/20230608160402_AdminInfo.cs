using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AdminInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustomerAnswer",
                table: "User_Answer",
                newName: "UserAnswers");

            migrationBuilder.AddColumn<string>(
                name: "ReservationState",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Admin_FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationState",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "Admin_FirstName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserAnswers",
                table: "User_Answer",
                newName: "CustomerAnswer");
        }
    }
}
