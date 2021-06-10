using BookReviewGrupp4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviewGrupp4.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedDatabase(this ModelBuilder modelBuilder)
        {
            modelBuilder.CreateAuthors();
            modelBuilder.CreateBooks();
            modelBuilder.CreateReviews();
        }

        public static void CreateAuthors(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 1, Name = "Robin Tranberg", Country = "Sweden" });
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 2, Name = "Stefan Trenh", Country = "China" });
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 3, Name = "Edwin Larsson", Country = "Colombia" });
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 4, Name = "Nils Brufors", Country = "Sweden" });
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 5, Name = "Fredrik Parkell", Country = "Sweden" });
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 6, Name = "Johan Nilsson", Country = "Sweden" });
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 7, Name = "Johannes Posse", Country = "Sweden" });
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 8, Name = "Simon Hörnfalk", Country = "Sweden" });
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 9, Name = "Andreas Lind", Country = "Sweden" });
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 10, Name = "Émile Nestor", Country = "Sweden" });
        }

        public static void CreateBooks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 1, Name = "David on adventure", Genre = "Horror", Published = new DateTime(2018, 04, 09), Description = "Hej this book is about david", AuthorId = 1 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 3, Name = "My life as an idiot", Genre = "Biography", Published = new DateTime(2021, 01, 02), Description = "This is my life as a fuckboy and examples on how you can become one too.", AuthorId = 3 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 4, Name = "How to cook real food", Genre = "Food", Published = new DateTime(2012, 06, 19), Description = "In this book I'll show you how to cook real food, without vegetables.", AuthorId = 4 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 2, Name = "Lift 200kg in a week", Genre = "Sport", Published = new DateTime(2010, 01, 12), Description = "This book will guide you on how to easily lift 200 kg in a week, provided that you already can lift 199 kg.", AuthorId = 2 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 5, Name = "How to become successful", Genre = "Economy", Published = new DateTime(2020, 03, 11), Description = "Hello, I'm Fredrik. I will show how you can become rich and successful by just eating falukorv every day for the rest of your life.", AuthorId = 5 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 6, Name = "How to get every trophy in every game", Genre = "Games", Published = new DateTime(2015, 10, 18), Description = "I'll guide you on how to get all the trophies in every game. Only for gamers so this book only supports Playstation players", AuthorId = 6 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 7, Name = "Breeding ducks", Genre = "Animals", Published = new DateTime(2016, 03, 29), Description = "How to breed baby ducklings.", AuthorId = 7 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 8, Name = "Simon är bäst", Genre = "Party", Published = new DateTime(2020, 08, 20), Description = "A book that represents SUT20's first party.", AuthorId = 8 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 9, Name = "Harre Parre", Genre = "Science fiction", Published = new DateTime(2015, 06, 09), Description = "A parody of Harry Potter.", AuthorId = 9 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 10, Name = "My cat from hell", Genre = "Survival", Published = new DateTime(2021, 01, 18), Description = "This is my own experience on how to survive with a cat from (hell).", AuthorId = 10 });
        }

        public static void CreateReviews(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 1, Date = new DateTime(2021, 08, 20, 17, 59, 59), Name = "Nils", Description = "I got recommended this after getting sick by the falukorv-diet a friend of mine put me on. This has changed my life.", Rating = 4, BookId = 4 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 2, Date = new DateTime(2010, 04, 20, 07, 46, 12), Name = "Olof Svahn", Description = "Vilken jävla fest, 33333333333333333333!", Rating = 5, BookId = 8 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 3, Date = new DateTime(2019, 08, 12, 17, 59, 59), Name = "Nestor", Description = "Pingo", Rating = 1, BookId = 5 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 4, Date = new DateTime(2021, 06, 20, 17, 12, 59), Name = "LukasTheMan69420", Description = "Meh, couldve been better. Weird guy, ok story.", Rating = 3, BookId = 1 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 5, Date = new DateTime(2020, 12, 20, 17, 59, 34), Name = "Svennis", Description = "This brought back alot of bad memories..", Rating = 2, BookId = 10 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 6, Date = new DateTime(2020, 08, 17, 04, 59, 07), Name = "Johannes", Description = "Kom igen Obama, du kan bättre", Rating = 3, BookId = 2 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 7, Date = new DateTime(2020, 06, 12, 17, 17, 34), Name = "Albin", Description = "I won the olympics in everything after reading this book, much wow", Rating = 5, BookId = 6 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 8, Date = new DateTime(2019, 12, 20, 17, 59, 12), Name = "Zlatan", Description = "The fact that this book did not mention me as a lion even once made it the worst shit Ive ever read!", Rating = 1, BookId = 7 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 9, Date = new DateTime(2021, 08, 20, 17, 59, 59), Name = "Stefan Löfven", Description = "Och så vill jag ha en kokt med bröd", Rating = 5, BookId = 4 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 10, Date = new DateTime(2020, 08, 20, 12, 59, 34), Name = "Louis", Description = "Great book with an amazing story", Rating = 4, BookId = 9 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 11, Date = new DateTime(2021, 02, 20, 17, 59, 59), Name = "HaxxT3ch", Description = "Wow, this is so bad, never thought id ever read something this bad", Rating = 1, BookId = 3 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 12, Date = new DateTime(2020, 02, 12, 17, 17, 59), Name = "Nestor", Description = "Meh", Rating = 3, BookId = 7 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 13, Date = new DateTime(2019, 06, 20, 14, 06, 34), Name = "Johannes", Description = "THIS IS ABSOLUTE GOLD, SHOULD BE A PRIZE WINNER", Rating = 5, BookId = 5 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 14, Date = new DateTime(2021, 11, 15, 17, 14, 59), Name = "Parkelloman", Description = "Tråkig, seg och allmänt grått tema, den här författaren får steppa upp asså", Rating = 1, BookId = 1 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 15, Date = new DateTime(2021, 08, 20, 14, 59, 06), Name = "Julia Nilsson", Description = "Rekommenderar inte.", Rating = 2, BookId = 8 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 16, Date = new DateTime(2019, 02, 17, 12, 59, 12), Name = "Sara", Description = "Mediocre book. Stood out in some areas as for example when Peter smacked that loser Graham in the face", Rating = 3, BookId = 6 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 17, Date = new DateTime(2019, 06, 20, 23, 59, 17), Name = "LukasTheMan69420", Description = "Gave me chills, great piece of literature", Rating = 4, BookId = 10 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 18, Date = new DateTime(2019, 11, 20, 17, 06, 59), Name = "Nils", Description = "Lived up to its expectations, great book!!!", Rating = 5, BookId = 5 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 19, Date = new DateTime(2020, 08, 17, 12, 59, 14), Name = "Nestor", Description = "Hade för i helskotta kunnat kränga massa EyBros istället för att köpa den här skiten", Rating = 1, BookId = 3 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 20, Date = new DateTime(2021, 02, 06, 02, 59, 04), Name = "Klara Petersson", Description = "No words, I just wasted real life time on this absolute trash of a book", Rating = 1, BookId = 7 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 21, Date = new DateTime(2020, 06, 11, 17, 14, 12), Name = "Steffe", Description = "Dålig, var inte tillräcligt med skånska influenser", Rating = 2, BookId = 4 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 22, Date = new DateTime(2021, 08, 25, 23, 59, 34), Name = "Obama", Description = "Yes we can.. More like hell no we cant. Try again Mr Nilsson!", Rating = 2, BookId = 6 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 23, Date = new DateTime(2020, 11, 20, 17, 59, 59), Name = "Madde", Description = "Great summerread, highly recommended!", Rating = 4, BookId = 2 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 24, Date = new DateTime(2021, 08, 14, 16, 12, 04), Name = "Fredrik", Description = "This dude and his book stinks", Rating = 1, BookId = 9 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 25, Date = new DateTime(2021, 11, 06, 17, 59, 59), Name = "FelixTheGray", Description = "Kreativiteten rinner ur mig, men grym bok typ", Rating = 5, BookId = 1 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 26, Date = new DateTime(2020, 02, 20, 17, 59, 06), Name = "Johannes", Description = "I suck at golf just as much as this book was terrible to read", Rating = 2, BookId = 10 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 27, Date = new DateTime(2012, 02, 14, 17, 12, 59), Name = "Louis", Description = "What if?", Rating = 1, BookId = 5 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 28, Date = new DateTime(2020, 08, 12, 04, 59, 04), Name = "Andreas", Description = "EYYYYYYYYYYY BRO", Rating = 3, BookId = 8 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 29, Date = new DateTime(2014, 08, 20, 17, 18, 45), Name = "Adam", Description = "I LOVED it!", Rating = 5, BookId = 3 });
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 30, Date = new DateTime(2021, 12, 20, 06, 59, 14), Name = "Johan Nilsson", Description = "What an amazing story!", Rating = 5, BookId = 4 });
        }
    }
}
