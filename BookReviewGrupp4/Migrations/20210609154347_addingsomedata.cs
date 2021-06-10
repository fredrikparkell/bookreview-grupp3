using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviewGrupp4.Migrations
{
    public partial class addingsomedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Country", "Name" },
                values: new object[] { 2, "Sweden", "Stefan Trenh" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Description", "Genre", "Name" },
                values: new object[] { "Hej this book is about david", "Horror", "David on adventure" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "Description", "Genre", "Name" },
                values: new object[] { "Hej", "Sweden", "Robin Tranberg" });
        }
    }
}
