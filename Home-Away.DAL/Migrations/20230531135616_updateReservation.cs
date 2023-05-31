using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updateReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "State",
                table: "Reservations",
                newName: "StateFromOwner");

            migrationBuilder.AddColumn<string>(
                name: "StateFromAdmin",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StateFromAdmin",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "StateFromOwner",
                table: "Reservations",
                newName: "State");
        }
    }
}
