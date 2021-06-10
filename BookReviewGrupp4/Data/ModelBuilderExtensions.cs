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
            modelBuilder.Entity<Author>().HasData(new Author { AuthorId = 2, Name = "Stefan Trenh", Country = "Sweden" });
        }

        public static void CreateBooks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 1, Name = "David on adventure", Genre = "Horror", Published = new DateTime(2018, 04, 09), Description = "Hej this book is about david", AuthorId = 1 });
        }

        public static void CreateReviews(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().HasData(new Review { ReviewId = 1, Name = "Nils Brufors", Description = "This book sucked", Rating = 0, BookId = 1 });
        }
    }
}
