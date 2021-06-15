using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviewGrupp4.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Published = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AverageRating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountReviews = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Book_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "AverageRating", "Country", "Name" },
                values: new object[,]
                {
                    { 1, 0m, "Unknown", "Unknown" },
                    { 3, 0m, "Sweden", "Robin Tranberg" },
                    { 2, 0m, "China", "Stefan Trenh" },
                    { 4, 0m, "Colombia", "Edwin Larsson" },
                    { 5, 0m, "Sweden", "Nils Brufors" },
                    { 6, 0m, "Sweden", "Fredrik Parkell" },
                    { 7, 0m, "Sweden", "Johan Nilsson" },
                    { 8, 0m, "Sweden", "Johannes Posse" },
                    { 9, 0m, "Sweden", "Simon Hörnfalk" },
                    { 10, 0m, "Sweden", "Andreas Lind" },
                    { 11, 0m, "Sweden", "Émile Nestor" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "AmountReviews", "AuthorId", "AverageRating", "Description", "Genre", "Name", "Published" },
                values: new object[,]
                {
                    { 2, 0, 3, 0m, "This book will guide you on how to easily lift 200 kg in a week, provided that you already can lift 199 kg.", "Sport", "Lift 200kg in a week", new DateTime(2010, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 0, 2, 0m, "Hej this book is about david", "Horror", "David on adventure", new DateTime(2018, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 0, 4, 0m, "This is my life as looking good and being dumb. As the result of having all my oxygen going through my muscles, instead of my brain.", "Biography", "My life as an idiot", new DateTime(2014, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 0, 5, 0m, "In this book I'll show you how to cook real food, without vegetables.", "Food", "How to cook real food", new DateTime(2012, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 0, 6, 0m, "Hello, I'm Fredrik. I will show how you can become rich and successful by just eating falukorv every day for the rest of your life.", "Economy", "How to become successful", new DateTime(2011, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 0, 7, 0m, "I'll guide you on how to get all the trophies in every game. Only for gamers so this book only supports Playstation players", "Games", "How to get every trophy in every game", new DateTime(2015, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 0, 8, 0m, "How to breed baby ducklings.", "Animals", "Breeding ducks", new DateTime(2016, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 0, 9, 0m, "A book that represents SUT20's first party.", "Party", "Simon är bäst", new DateTime(2009, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 0, 10, 0m, "A parody of Harry Potter.", "Science fiction", "Harre Parre", new DateTime(2015, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 0, 11, 0m, "This is my own experience on how to survive with a cat from hell.", "Survival", "My cat from hell", new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "ReviewId", "BookId", "Date", "Description", "Name", "Rating" },
                values: new object[,]
                {
                    { 6, 2, new DateTime(2020, 8, 17, 4, 59, 7, 0, DateTimeKind.Unspecified), "Kom igen Obama, du kan bättre", "Johannes", 3m },
                    { 5, 10, new DateTime(2021, 4, 20, 17, 59, 34, 0, DateTimeKind.Unspecified), "This brought back alot of bad memories..", "Svennis", 2m },
                    { 24, 9, new DateTime(2021, 3, 14, 16, 12, 4, 0, DateTimeKind.Unspecified), "This dude and his book stinks", "Fredrik", 1m },
                    { 10, 9, new DateTime(2020, 8, 20, 12, 59, 34, 0, DateTimeKind.Unspecified), "Great book with an amazing story", "Louis", 4m },
                    { 28, 8, new DateTime(2020, 6, 12, 4, 59, 4, 0, DateTimeKind.Unspecified), "EYYYYYYYYYYY BRO", "Andreas", 3m },
                    { 15, 8, new DateTime(2021, 4, 20, 14, 59, 6, 0, DateTimeKind.Unspecified), "Rekommenderar inte.", "Julia Nilsson", 2m },
                    { 2, 8, new DateTime(2010, 4, 20, 7, 46, 12, 0, DateTimeKind.Unspecified), "Vilken jävla fest, 33333333333333333333!", "Olof Svahn", 5m },
                    { 20, 7, new DateTime(2021, 5, 6, 2, 59, 4, 0, DateTimeKind.Unspecified), "No words, I just wasted real life time on this absolute trash of a book", "Klara Petersson", 1m },
                    { 12, 7, new DateTime(2020, 2, 12, 17, 17, 59, 0, DateTimeKind.Unspecified), "Meh", "Nestor", 3m },
                    { 8, 7, new DateTime(2019, 12, 20, 17, 59, 12, 0, DateTimeKind.Unspecified), "The fact that this book did not mention me as a lion even once made it the worst shit Ive ever read!", "Zlatan", 1m },
                    { 22, 6, new DateTime(2021, 2, 25, 23, 59, 34, 0, DateTimeKind.Unspecified), "Yes we can.. More like hell no we cant. Try again Mr Nilsson!", "Obama", 2m },
                    { 16, 6, new DateTime(2019, 2, 17, 12, 59, 12, 0, DateTimeKind.Unspecified), "Mediocre book. Stood out in some areas as for example when Peter smacked that loser Graham in the face", "Sara", 3m },
                    { 7, 6, new DateTime(2020, 6, 12, 17, 17, 34, 0, DateTimeKind.Unspecified), "I won the olympics in everything after reading this book, much wow", "Albin", 5m },
                    { 27, 5, new DateTime(2012, 2, 14, 17, 12, 59, 0, DateTimeKind.Unspecified), "What if?", "Louis", 1m },
                    { 18, 5, new DateTime(2019, 11, 20, 17, 6, 59, 0, DateTimeKind.Unspecified), "Lived up to its expectations, great book!!!", "Nils", 5m },
                    { 13, 5, new DateTime(2019, 6, 20, 14, 6, 34, 0, DateTimeKind.Unspecified), "THIS IS ABSOLUTE GOLD, SHOULD BE A PRIZE WINNER", "Johannes", 5m },
                    { 3, 5, new DateTime(2019, 8, 12, 17, 59, 59, 0, DateTimeKind.Unspecified), "Pingo", "Nestor", 1m },
                    { 30, 4, new DateTime(2021, 2, 20, 6, 59, 14, 0, DateTimeKind.Unspecified), "What an amazing story!", "Johan Nilsson", 5m },
                    { 21, 4, new DateTime(2020, 6, 11, 17, 14, 12, 0, DateTimeKind.Unspecified), "Dålig, var inte tillräcligt med skånska influenser", "Steffe", 2m },
                    { 9, 4, new DateTime(2021, 3, 20, 17, 59, 59, 0, DateTimeKind.Unspecified), "Och så vill jag ha en kokt med bröd", "Stefan Löfven", 5m },
                    { 1, 4, new DateTime(2021, 2, 20, 17, 59, 59, 0, DateTimeKind.Unspecified), "I got recommended this after getting sick by the falukorv-diet a friend of mine put me on. This has changed my life.", "Nils", 4m },
                    { 29, 3, new DateTime(2014, 8, 20, 17, 18, 45, 0, DateTimeKind.Unspecified), "I LOVED it!", "Adam", 5m },
                    { 19, 3, new DateTime(2020, 8, 17, 12, 59, 14, 0, DateTimeKind.Unspecified), "Hade för i helskotta kunnat kränga massa EyBros istället för att köpa den här skiten", "Nestor", 1m },
                    { 11, 3, new DateTime(2021, 2, 20, 17, 59, 59, 0, DateTimeKind.Unspecified), "Wow, this is so bad, never thought id ever read something this bad", "HaxxT3ch", 1m },
                    { 25, 1, new DateTime(2021, 1, 6, 17, 59, 59, 0, DateTimeKind.Unspecified), "Kreativiteten rinner ur mig, men grym bok typ", "FelixTheGray", 5m },
                    { 14, 1, new DateTime(2021, 1, 15, 17, 14, 59, 0, DateTimeKind.Unspecified), "Tråkig, seg och allmänt grått tema, den här författaren får steppa upp asså", "Parkelloman", 1m },
                    { 4, 1, new DateTime(2021, 1, 20, 17, 12, 59, 0, DateTimeKind.Unspecified), "Meh, couldve been better. Weird guy, ok story.", "LukasTheMan69420", 3m },
                    { 23, 2, new DateTime(2020, 11, 20, 17, 59, 59, 0, DateTimeKind.Unspecified), "Great summerread, highly recommended!", "Madde", 4m },
                    { 17, 10, new DateTime(2021, 6, 13, 23, 59, 17, 0, DateTimeKind.Unspecified), "Gave me chills, great piece of literature", "LukasTheMan69420", 4m },
                    { 26, 10, new DateTime(2021, 2, 20, 17, 59, 6, 0, DateTimeKind.Unspecified), "I suck at golf just as much as this book was terrible to read", "Johannes", 2m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_BookId",
                table: "Review",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
