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
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 3, Name = "My life as a fuckboy", Genre = "Biografy", Published = new DateTime(2021, 01, 02), Description = "This is my life as a fuckboy and examples on how you can become one too.", AuthorId = 3 });
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
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 1, Name = "Nils Brufors", Description = "This book sucked", Rating = 3, BookId = 1 });
        }
    }
}
