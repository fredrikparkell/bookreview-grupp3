﻿// <auto-generated />
using System;
using BookReviewGrupp4.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookReviewGrupp4.Migrations
{
    [DbContext(typeof(BookReviewContext))]
    [Migration("20210610155207_dataAddedReviews")]
    partial class dataAddedReviews
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookReviewGrupp4.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("AuthorId");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Country = "Sweden",
                            Name = "Robin Tranberg"
                        },
                        new
                        {
                            AuthorId = 2,
                            Country = "China",
                            Name = "Stefan Trenh"
                        },
                        new
                        {
                            AuthorId = 3,
                            Country = "Colombia",
                            Name = "Edwin Larsson"
                        },
                        new
                        {
                            AuthorId = 4,
                            Country = "Sweden",
                            Name = "Nils Brufors"
                        },
                        new
                        {
                            AuthorId = 5,
                            Country = "Sweden",
                            Name = "Fredrik Parkell"
                        },
                        new
                        {
                            AuthorId = 6,
                            Country = "Sweden",
                            Name = "Johan Nilsson"
                        },
                        new
                        {
                            AuthorId = 7,
                            Country = "Sweden",
                            Name = "Johannes Posse"
                        },
                        new
                        {
                            AuthorId = 8,
                            Country = "Sweden",
                            Name = "Simon Hörnfalk"
                        },
                        new
                        {
                            AuthorId = 9,
                            Country = "Sweden",
                            Name = "Andreas Lind"
                        },
                        new
                        {
                            AuthorId = 10,
                            Country = "Sweden",
                            Name = "Émile Nestor"
                        });
                });

            modelBuilder.Entity("BookReviewGrupp4.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<decimal>("AverageRating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Published")
                        .HasColumnType("datetime2");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorId = 1,
                            AverageRating = 0m,
                            Description = "Hej this book is about david",
                            Genre = "Horror",
                            Name = "David on adventure",
                            Published = new DateTime(2018, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 3,
                            AuthorId = 3,
                            AverageRating = 0m,
                            Description = "This is my life as a fuckboy and examples on how you can become one too.",
                            Genre = "Biography",
                            Name = "My life as an idiot",
                            Published = new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 4,
                            AuthorId = 4,
                            AverageRating = 0m,
                            Description = "In this book I'll show you how to cook real food, without vegetables.",
                            Genre = "Food",
                            Name = "How to cook real food",
                            Published = new DateTime(2012, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 2,
                            AuthorId = 2,
                            AverageRating = 0m,
                            Description = "This book will guide you on how to easily lift 200 kg in a week, provided that you already can lift 199 kg.",
                            Genre = "Sport",
                            Name = "Lift 200kg in a week",
                            Published = new DateTime(2010, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 5,
                            AuthorId = 5,
                            AverageRating = 0m,
                            Description = "Hello, I'm Fredrik. I will show how you can become rich and successful by just eating falukorv every day for the rest of your life.",
                            Genre = "Economy",
                            Name = "How to become successful",
                            Published = new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 6,
                            AuthorId = 6,
                            AverageRating = 0m,
                            Description = "I'll guide you on how to get all the trophies in every game. Only for gamers so this book only supports Playstation players",
                            Genre = "Games",
                            Name = "How to get every trophy in every game",
                            Published = new DateTime(2015, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 7,
                            AuthorId = 7,
                            AverageRating = 0m,
                            Description = "How to breed baby ducklings.",
                            Genre = "Animals",
                            Name = "Breeding ducks",
                            Published = new DateTime(2016, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 8,
                            AuthorId = 8,
                            AverageRating = 0m,
                            Description = "A book that represents SUT20's first party.",
                            Genre = "Party",
                            Name = "Simon är bäst",
                            Published = new DateTime(2020, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 9,
                            AuthorId = 9,
                            AverageRating = 0m,
                            Description = "A parody of Harry Potter.",
                            Genre = "Science fiction",
                            Name = "Harre Parre",
                            Published = new DateTime(2015, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookId = 10,
                            AuthorId = 10,
                            AverageRating = 0m,
                            Description = "This is my own experience on how to survive with a cat from (hell).",
                            Genre = "Survival",
                            Name = "My cat from hell",
                            Published = new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BookReviewGrupp4.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ReviewId");

                    b.HasIndex("BookId");

                    b.ToTable("Review");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            BookId = 4,
                            Date = new DateTime(2021, 8, 20, 17, 59, 59, 0, DateTimeKind.Unspecified),
                            Description = "I got recommended this after getting sick by the falukorv-diet a friend of mine put me on. This has changed my life.",
                            Name = "Nils",
                            Rating = 4m
                        },
                        new
                        {
                            ReviewId = 2,
                            BookId = 8,
                            Date = new DateTime(2010, 4, 20, 7, 46, 12, 0, DateTimeKind.Unspecified),
                            Description = "Vilken jävla fest, 33333333333333333333!",
                            Name = "Olof Svahn",
                            Rating = 5m
                        },
                        new
                        {
                            ReviewId = 3,
                            BookId = 5,
                            Date = new DateTime(2019, 8, 12, 17, 59, 59, 0, DateTimeKind.Unspecified),
                            Description = "Pingo",
                            Name = "Nestor",
                            Rating = 1m
                        },
                        new
                        {
                            ReviewId = 4,
                            BookId = 1,
                            Date = new DateTime(2021, 6, 20, 17, 12, 59, 0, DateTimeKind.Unspecified),
                            Description = "Meh, couldve been better. Weird guy, ok story.",
                            Name = "LukasTheMan69420",
                            Rating = 3m
                        },
                        new
                        {
                            ReviewId = 5,
                            BookId = 10,
                            Date = new DateTime(2020, 12, 20, 17, 59, 34, 0, DateTimeKind.Unspecified),
                            Description = "This brought back alot of bad memories..",
                            Name = "Svennis",
                            Rating = 2m
                        },
                        new
                        {
                            ReviewId = 6,
                            BookId = 2,
                            Date = new DateTime(2020, 8, 17, 4, 59, 7, 0, DateTimeKind.Unspecified),
                            Description = "Kom igen Obama, du kan bättre",
                            Name = "Johannes",
                            Rating = 3m
                        },
                        new
                        {
                            ReviewId = 7,
                            BookId = 6,
                            Date = new DateTime(2020, 6, 12, 17, 17, 34, 0, DateTimeKind.Unspecified),
                            Description = "I won the olympics in everything after reading this book, much wow",
                            Name = "Albin",
                            Rating = 5m
                        },
                        new
                        {
                            ReviewId = 8,
                            BookId = 7,
                            Date = new DateTime(2019, 12, 20, 17, 59, 12, 0, DateTimeKind.Unspecified),
                            Description = "The fact that this book did not mention me as a lion even once made it the worst shit Ive ever read!",
                            Name = "Zlatan",
                            Rating = 1m
                        },
                        new
                        {
                            ReviewId = 9,
                            BookId = 4,
                            Date = new DateTime(2021, 8, 20, 17, 59, 59, 0, DateTimeKind.Unspecified),
                            Description = "Och så vill jag ha en kokt med bröd",
                            Name = "Stefan Löfven",
                            Rating = 5m
                        },
                        new
                        {
                            ReviewId = 10,
                            BookId = 9,
                            Date = new DateTime(2020, 8, 20, 12, 59, 34, 0, DateTimeKind.Unspecified),
                            Description = "Great book with an amazing story",
                            Name = "Louis",
                            Rating = 4m
                        },
                        new
                        {
                            ReviewId = 11,
                            BookId = 3,
                            Date = new DateTime(2021, 2, 20, 17, 59, 59, 0, DateTimeKind.Unspecified),
                            Description = "Wow, this is so bad, never thought id ever read something this bad",
                            Name = "HaxxT3ch",
                            Rating = 1m
                        },
                        new
                        {
                            ReviewId = 12,
                            BookId = 7,
                            Date = new DateTime(2020, 2, 12, 17, 17, 59, 0, DateTimeKind.Unspecified),
                            Description = "Meh",
                            Name = "Nestor",
                            Rating = 3m
                        },
                        new
                        {
                            ReviewId = 13,
                            BookId = 5,
                            Date = new DateTime(2019, 6, 20, 14, 6, 34, 0, DateTimeKind.Unspecified),
                            Description = "THIS IS ABSOLUTE GOLD, SHOULD BE A PRIZE WINNER",
                            Name = "Johannes",
                            Rating = 5m
                        },
                        new
                        {
                            ReviewId = 14,
                            BookId = 1,
                            Date = new DateTime(2021, 11, 15, 17, 14, 59, 0, DateTimeKind.Unspecified),
                            Description = "Tråkig, seg och allmänt grått tema, den här författaren får steppa upp asså",
                            Name = "Parkelloman",
                            Rating = 1m
                        },
                        new
                        {
                            ReviewId = 15,
                            BookId = 8,
                            Date = new DateTime(2021, 8, 20, 14, 59, 6, 0, DateTimeKind.Unspecified),
                            Description = "Rekommenderar inte.",
                            Name = "Julia Nilsson",
                            Rating = 2m
                        },
                        new
                        {
                            ReviewId = 16,
                            BookId = 6,
                            Date = new DateTime(2019, 2, 17, 12, 59, 12, 0, DateTimeKind.Unspecified),
                            Description = "Mediocre book. Stood out in some areas as for example when Peter smacked that loser Graham in the face",
                            Name = "Sara",
                            Rating = 3m
                        },
                        new
                        {
                            ReviewId = 17,
                            BookId = 10,
                            Date = new DateTime(2019, 6, 20, 23, 59, 17, 0, DateTimeKind.Unspecified),
                            Description = "Gave me chills, great piece of literature",
                            Name = "LukasTheMan69420",
                            Rating = 4m
                        },
                        new
                        {
                            ReviewId = 18,
                            BookId = 5,
                            Date = new DateTime(2019, 11, 20, 17, 6, 59, 0, DateTimeKind.Unspecified),
                            Description = "Lived up to its expectations, great book!!!",
                            Name = "Nils",
                            Rating = 5m
                        },
                        new
                        {
                            ReviewId = 19,
                            BookId = 3,
                            Date = new DateTime(2020, 8, 17, 12, 59, 14, 0, DateTimeKind.Unspecified),
                            Description = "Hade för i helskotta kunnat kränga massa EyBros istället för att köpa den här skiten",
                            Name = "Nestor",
                            Rating = 1m
                        },
                        new
                        {
                            ReviewId = 20,
                            BookId = 7,
                            Date = new DateTime(2021, 2, 6, 2, 59, 4, 0, DateTimeKind.Unspecified),
                            Description = "No words, I just wasted real life time on this absolute trash of a book",
                            Name = "Klara Petersson",
                            Rating = 1m
                        },
                        new
                        {
                            ReviewId = 21,
                            BookId = 4,
                            Date = new DateTime(2020, 6, 11, 17, 14, 12, 0, DateTimeKind.Unspecified),
                            Description = "Dålig, var inte tillräcligt med skånska influenser",
                            Name = "Steffe",
                            Rating = 2m
                        },
                        new
                        {
                            ReviewId = 22,
                            BookId = 6,
                            Date = new DateTime(2021, 8, 25, 23, 59, 34, 0, DateTimeKind.Unspecified),
                            Description = "Yes we can.. More like hell no we cant. Try again Mr Nilsson!",
                            Name = "Obama",
                            Rating = 2m
                        },
                        new
                        {
                            ReviewId = 23,
                            BookId = 2,
                            Date = new DateTime(2020, 11, 20, 17, 59, 59, 0, DateTimeKind.Unspecified),
                            Description = "Great summerread, highly recommended!",
                            Name = "Madde",
                            Rating = 4m
                        },
                        new
                        {
                            ReviewId = 24,
                            BookId = 9,
                            Date = new DateTime(2021, 8, 14, 16, 12, 4, 0, DateTimeKind.Unspecified),
                            Description = "This dude and his book stinks",
                            Name = "Fredrik",
                            Rating = 1m
                        },
                        new
                        {
                            ReviewId = 25,
                            BookId = 1,
                            Date = new DateTime(2021, 11, 6, 17, 59, 59, 0, DateTimeKind.Unspecified),
                            Description = "Kreativiteten rinner ur mig, men grym bok typ",
                            Name = "FelixTheGray",
                            Rating = 5m
                        },
                        new
                        {
                            ReviewId = 26,
                            BookId = 10,
                            Date = new DateTime(2020, 2, 20, 17, 59, 6, 0, DateTimeKind.Unspecified),
                            Description = "I suck at golf just as much as this book was terrible to read",
                            Name = "Johannes",
                            Rating = 2m
                        },
                        new
                        {
                            ReviewId = 27,
                            BookId = 5,
                            Date = new DateTime(2012, 2, 14, 17, 12, 59, 0, DateTimeKind.Unspecified),
                            Description = "What if?",
                            Name = "Louis",
                            Rating = 1m
                        },
                        new
                        {
                            ReviewId = 28,
                            BookId = 8,
                            Date = new DateTime(2020, 8, 12, 4, 59, 4, 0, DateTimeKind.Unspecified),
                            Description = "EYYYYYYYYYYY BRO",
                            Name = "Andreas",
                            Rating = 3m
                        },
                        new
                        {
                            ReviewId = 29,
                            BookId = 3,
                            Date = new DateTime(2014, 8, 20, 17, 18, 45, 0, DateTimeKind.Unspecified),
                            Description = "I LOVED it!",
                            Name = "Adam",
                            Rating = 5m
                        },
                        new
                        {
                            ReviewId = 30,
                            BookId = 4,
                            Date = new DateTime(2021, 12, 20, 6, 59, 14, 0, DateTimeKind.Unspecified),
                            Description = "What an amazing story!",
                            Name = "Johan Nilsson",
                            Rating = 5m
                        });
                });

            modelBuilder.Entity("BookReviewGrupp4.Models.Book", b =>
                {
                    b.HasOne("BookReviewGrupp4.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("BookReviewGrupp4.Models.Review", b =>
                {
                    b.HasOne("BookReviewGrupp4.Models.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BookReviewGrupp4.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookReviewGrupp4.Models.Book", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
