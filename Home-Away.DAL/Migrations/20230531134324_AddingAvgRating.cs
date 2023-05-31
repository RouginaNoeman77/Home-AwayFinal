using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Home_Away.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddingAvgRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AverageRating",
                table: "Property",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageRating",
                table: "Property");
        }
    }
}
