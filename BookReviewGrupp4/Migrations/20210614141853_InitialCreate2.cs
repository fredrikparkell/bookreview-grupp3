using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviewGrupp4.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 1,
                columns: new[] { "Country", "Name" },
                values: new object[] { "Unknown", "Unknown" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3,
                columns: new[] { "Country", "Name" },
                values: new object[] { "Sweden", "Robin Tranberg" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                columns: new[] { "Country", "Name" },
                values: new object[] { "Colombia", "Edwin Larsson" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 5,
                column: "Name",
                value: "Nils Brufors");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 6,
                column: "Name",
                value: "Fredrik Parkell");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 7,
                column: "Name",
                value: "Johan Nilsson");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 8,
                column: "Name",
                value: "Johannes Posse");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 9,
                column: "Name",
                value: "Simon Hörnfalk");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 10,
                column: "Name",
                value: "Andreas Lind");

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "AverageRating", "Country", "Name" },
                values: new object[] { 11, 0m, "Sweden", "Émile Nestor" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "AuthorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "AuthorId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "AuthorId", "Description", "Published" },
                values: new object[] { 4, "This is my life as looking good and being dumb. As the result of having all my oxygen going through my muscles, instead of my brain.", new DateTime(2014, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "AuthorId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "AuthorId", "Published" },
                values: new object[] { 6, new DateTime(2011, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 6,
                column: "AuthorId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 7,
                column: "AuthorId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "AuthorId", "Published" },
                values: new object[] { 9, new DateTime(2009, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 9,
                column: "AuthorId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 2, 20, 17, 59, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 1, 20, 17, 12, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 4, 20, 17, 59, 34, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 3, 20, 17, 59, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2021, 1, 15, 17, 14, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2021, 4, 20, 14, 59, 6, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2021, 6, 13, 23, 59, 17, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2021, 5, 6, 2, 59, 4, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2021, 2, 25, 23, 59, 34, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2021, 3, 14, 16, 12, 4, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2021, 1, 6, 17, 59, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2021, 2, 20, 17, 59, 6, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2020, 6, 12, 4, 59, 4, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2021, 2, 20, 6, 59, 14, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "AuthorId", "Description" },
                values: new object[] { 11, "This is my own experience on how to survive with a cat from hell." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 1,
                columns: new[] { "Country", "Name" },
                values: new object[] { "Sweden", "Robin Tranberg" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3,
                columns: new[] { "Country", "Name" },
                values: new object[] { "Colombia", "Edwin Larsson" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4,
                columns: new[] { "Country", "Name" },
                values: new object[] { "Sweden", "Nils Brufors" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 5,
                column: "Name",
                value: "Fredrik Parkell");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 6,
                column: "Name",
                value: "Johan Nilsson");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 7,
                column: "Name",
                value: "Johannes Posse");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 8,
                column: "Name",
                value: "Simon Hörnfalk");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 9,
                column: "Name",
                value: "Andreas Lind");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 10,
                column: "Name",
                value: "Émile Nestor");

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "AuthorId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "AuthorId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "AuthorId", "Description", "Published" },
                values: new object[] { 3, "This is my life as a fuckboy and examples on how you can become one too.", new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4,
                column: "AuthorId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "AuthorId", "Published" },
                values: new object[] { 5, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 6,
                column: "AuthorId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 7,
                column: "AuthorId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "AuthorId", "Published" },
                values: new object[] { 8, new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 9,
                column: "AuthorId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "AuthorId", "Description" },
                values: new object[] { 10, "This is my own experience on how to survive with a cat from (hell)." });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 8, 20, 17, 59, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 6, 20, 17, 12, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 12, 20, 17, 59, 34, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 8, 20, 17, 59, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2021, 11, 15, 17, 14, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2021, 8, 20, 14, 59, 6, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2019, 6, 20, 23, 59, 17, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2021, 2, 6, 2, 59, 4, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2021, 8, 25, 23, 59, 34, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2021, 8, 14, 16, 12, 4, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2021, 11, 6, 17, 59, 59, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2020, 2, 20, 17, 59, 6, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2020, 8, 12, 4, 59, 4, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2021, 12, 20, 6, 59, 14, 0, DateTimeKind.Unspecified));
        }
    }
}
