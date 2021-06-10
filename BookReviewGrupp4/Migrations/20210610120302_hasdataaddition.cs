using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviewGrupp4.Migrations
{
    public partial class hasdataaddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Review",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Review",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Book",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Author",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "Country",
                value: "China");

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "AuthorId", "Country", "Name" },
                values: new object[,]
                {
                    { 3, "Colombia", "Edwin Larsson" },
                    { 4, "Sweden", "Nils Brufors" },
                    { 5, "Sweden", "Fredrik Parkell" },
                    { 6, "Sweden", "Johan Nilsson" },
                    { 7, "Sweden", "Johannes Posse" },
                    { 8, "Sweden", "Simon Hörnfalk" },
                    { 9, "Sweden", "Andreas Lind" },
                    { 10, "Sweden", "Émile Nestor" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "AuthorId", "AverageRating", "Description", "Genre", "Name", "Published" },
                values: new object[] { 2, 2, 0m, "This book will guide you on how to easily lift 200 kg in a week, provided that you already can lift 199 kg.", "Sport", "Lift 200kg in a week", new DateTime(2010, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Rating",
                value: 3m);

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "AuthorId", "AverageRating", "Description", "Genre", "Name", "Published" },
                values: new object[,]
                {
                    { 3, 3, 0m, "This is my life as a fuckboy and examples on how you can become one too.", "Biografy", "My life as a fuckboy", new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 0m, "In this book I'll show you how to cook real food, without vegetables.", "Food", "How to cook real food", new DateTime(2012, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, 0m, "Hello, I'm Fredrik. I will show how you can become rich and successful by just eating falukorv every day for the rest of your life.", "Economy", "How to become successful", new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, 0m, "I'll guide you on how to get all the trophies in every game. Only for gamers so this book only supports Playstation players", "Games", "How to get every trophy in every game", new DateTime(2015, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, 0m, "How to breed baby ducklings.", "Animals", "Breeding ducks", new DateTime(2016, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, 0m, "A book that represents SUT20's first party.", "Party", "Simon är bäst", new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 9, 0m, "A parody of Harry Potter.", "Science fiction", "Harre Parre", new DateTime(2015, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, 0m, "This is my own experience on how to survive with a cat from (hell).", "Survival", "My cat from hell", new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Review",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Review",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Author",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "Country",
                value: "Sweden");

            migrationBuilder.UpdateData(
                table: "Review",
                keyColumn: "ReviewId",
                keyValue: 1,
                column: "Rating",
                value: 0m);
        }
    }
}
