using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviewGrupp4.Migrations
{
    public partial class testnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmountReviews",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "AverageRating",
                table: "Author",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountReviews",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AverageRating",
                table: "Author");
        }
    }
}
