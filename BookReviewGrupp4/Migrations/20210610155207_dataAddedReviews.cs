using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviewGrupp4.Migrations
{
    public partial class dataAddedReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "Genre", "Name" },
                values: new object[] { "Biography", "My life as an idiot" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "BookId", "Date", "Description", "Name", "Rating" },
                values: new object[] { 4, new DateTime(2021, 8, 20, 17, 59, 59, 0, DateTimeKind.Unspecified), "I got recommended this after getting sick by the falukorv-diet a friend of mine put me on. This has changed my life.", "Nils", 4m });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "BookId", "Date", "Description", "Name", "Rating" },
                values: new object[,]
                {
                    { 30, 4, new DateTime(2021, 12, 20, 6, 59, 14, 0, DateTimeKind.Unspecified), "What an amazing story!", "Johan Nilsson", 5m },
                    { 29, 3, new DateTime(2014, 8, 20, 17, 18, 45, 0, DateTimeKind.Unspecified), "I LOVED it!", "Adam", 5m },
                    { 28, 8, new DateTime(2020, 8, 12, 4, 59, 4, 0, DateTimeKind.Unspecified), "EYYYYYYYYYYY BRO", "Andreas", 3m },
                    { 27, 5, new DateTime(2012, 2, 14, 17, 12, 59, 0, DateTimeKind.Unspecified), "What if?", "Louis", 1m },
                    { 26, 10, new DateTime(2020, 2, 20, 17, 59, 6, 0, DateTimeKind.Unspecified), "I suck at golf just as much as this book was terrible to read", "Johannes", 2m },
                    { 25, 1, new DateTime(2021, 11, 6, 17, 59, 59, 0, DateTimeKind.Unspecified), "Kreativiteten rinner ur mig, men grym bok typ", "FelixTheGray", 5m },
                    { 24, 9, new DateTime(2021, 8, 14, 16, 12, 4, 0, DateTimeKind.Unspecified), "This dude and his book stinks", "Fredrik", 1m },
                    { 23, 2, new DateTime(2020, 11, 20, 17, 59, 59, 0, DateTimeKind.Unspecified), "Great summerread, highly recommended!", "Madde", 4m },
                    { 22, 6, new DateTime(2021, 8, 25, 23, 59, 34, 0, DateTimeKind.Unspecified), "Yes we can.. More like hell no we cant. Try again Mr Nilsson!", "Obama", 2m },
                    { 21, 4, new DateTime(2020, 6, 11, 17, 14, 12, 0, DateTimeKind.Unspecified), "Dålig, var inte tillräcligt med skånska influenser", "Steffe", 2m },
                    { 20, 7, new DateTime(2021, 2, 6, 2, 59, 4, 0, DateTimeKind.Unspecified), "No words, I just wasted real life time on this absolute trash of a book", "Klara Petersson", 1m },
                    { 19, 3, new DateTime(2020, 8, 17, 12, 59, 14, 0, DateTimeKind.Unspecified), "Hade för i helskotta kunnat kränga massa EyBros istället för att köpa den här skiten", "Nestor", 1m },
                    { 18, 5, new DateTime(2019, 11, 20, 17, 6, 59, 0, DateTimeKind.Unspecified), "Lived up to its expectations, great book!!!", "Nils", 5m },
                    { 17, 10, new DateTime(2019, 6, 20, 23, 59, 17, 0, DateTimeKind.Unspecified), "Gave me chills, great piece of literature", "LukasTheMan69420", 4m },
                    { 15, 8, new DateTime(2021, 8, 20, 14, 59, 6, 0, DateTimeKind.Unspecified), "Rekommenderar inte.", "Julia Nilsson", 2m },
                    { 14, 1, new DateTime(2021, 11, 15, 17, 14, 59, 0, DateTimeKind.Unspecified), "Tråkig, seg och allmänt grått tema, den här författaren får steppa upp asså", "Parkelloman", 1m },
                    { 13, 5, new DateTime(2019, 6, 20, 14, 6, 34, 0, DateTimeKind.Unspecified), "THIS IS ABSOLUTE GOLD, SHOULD BE A PRIZE WINNER", "Johannes", 5m },
                    { 12, 7, new DateTime(2020, 2, 12, 17, 17, 59, 0, DateTimeKind.Unspecified), "Meh", "Nestor", 3m },
                    { 11, 3, new DateTime(2021, 2, 20, 17, 59, 59, 0, DateTimeKind.Unspecified), "Wow, this is so bad, never thought id ever read something this bad", "HaxxT3ch", 1m },
                    { 10, 9, new DateTime(2020, 8, 20, 12, 59, 34, 0, DateTimeKind.Unspecified), "Great book with an amazing story", "Louis", 4m },
                    { 9, 4, new DateTime(2021, 8, 20, 17, 59, 59, 0, DateTimeKind.Unspecified), "Och så vill jag ha en kokt med bröd", "Stefan Löfven", 5m },
                    { 8, 7, new DateTime(2019, 12, 20, 17, 59, 12, 0, DateTimeKind.Unspecified), "The fact that this book did not mention me as a lion even once made it the worst shit Ive ever read!", "Zlatan", 1m },
                    { 7, 6, new DateTime(2020, 6, 12, 17, 17, 34, 0, DateTimeKind.Unspecified), "I won the olympics in everything after reading this book, much wow", "Albin", 5m },
                    { 6, 2, new DateTime(2020, 8, 17, 4, 59, 7, 0, DateTimeKind.Unspecified), "Kom igen Obama, du kan bättre", "Johannes", 3m },
                    { 5, 10, new DateTime(2020, 12, 20, 17, 59, 34, 0, DateTimeKind.Unspecified), "This brought back alot of bad memories..", "Svennis", 2m },
                    { 4, 1, new DateTime(2021, 6, 20, 17, 12, 59, 0, DateTimeKind.Unspecified), "Meh, couldve been better. Weird guy, ok story.", "LukasTheMan69420", 3m },
                    { 3, 5, new DateTime(2019, 8, 12, 17, 59, 59, 0, DateTimeKind.Unspecified), "Pingo", "Nestor", 1m },
                    { 16, 6, new DateTime(2019, 2, 17, 12, 59, 12, 0, DateTimeKind.Unspecified), "Mediocre book. Stood out in some areas as for example when Peter smacked that loser Graham in the face", "Sara", 3m },
                    { 2, 8, new DateTime(2010, 4, 20, 7, 46, 12, 0, DateTimeKind.Unspecified), "Vilken jävla fest, 33333333333333333333!", "Olof Svahn", 5m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "Genre", "Name" },
                values: new object[] { "Biografy", "My life as a fuckboy" });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                columns: new[] { "BookId", "Date", "Description", "Name", "Rating" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This book sucked", "Nils Brufors", 3m });
        }
    }
}
