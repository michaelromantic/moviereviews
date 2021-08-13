﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies;

namespace Movies.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20210813160612_update1")]
    partial class update1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Movies.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Animation"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Classics"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Documentary"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Kids & Family"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Romance"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Sci-fi & Fantasy"
                        });
                });

            modelBuilder.Entity("Movies.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReleaseYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Writer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Astronaut Sam Bell has a quintessentially personal encounter toward the end of his three-year stint on the Moon, where he, working alongside his computer, GERTY, sends back to Earth parcels of a resource that has helped diminish our planet's power problems.",
                            Director = "Duncan Jones",
                            GenreId = 11,
                            Image = "https://m.media-amazon.com/images/M/MV5BMTgzODgyNTQwOV5BMl5BanBnXkFtZTcwNzc0NTc0Mg@@._V1_.jpg",
                            ReleaseYear = "2009",
                            Title = "Moon",
                            Writer = "Duncan Jones"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The Griswold family's plans for a big family Christmas predictably turn into a big disaster.",
                            Director = "Jeremiah S. Chechik",
                            GenreId = 4,
                            Image = "https://m.media-amazon.com/images/I/71ONLW9CWHL._AC_SL1000_.jpg",
                            ReleaseYear = "1989",
                            Title = "Christmas Vacation",
                            Writer = "John Hughes"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The aliens are coming and their goal is to invade and destroy Earth. Fighting superior technology, mankind's best weapon is the will to survive.",
                            Director = "Roland Emmerich",
                            GenreId = 1,
                            Image = "https://m.media-amazon.com/images/M/MV5BMGQwNDNkMmItYWY1Yy00YTZmLWE5OTAtODU0MGZmMzQ1NDdkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_UY1200_CR85,0,630,1200_AL_.jpg",
                            ReleaseYear = "1996",
                            Title = "Independence Day",
                            Writer = "Dean Devlin & Roland Emmerich"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Fifteen years after murdering his sister on Halloween night 1963, Michael Myers escapes from a mental hospital and returns to the small town of Haddonfield, Illinois to kill again.",
                            Director = "John Carpenter",
                            GenreId = 7,
                            Image = "https://m.media-amazon.com/images/I/61NDDpRDDJL._AC_SY741_.jpg",
                            ReleaseYear = "1978",
                            Title = "Halloween",
                            Writer = "John Carpenter & Debra Hill"
                        },
                        new
                        {
                            Id = 5,
                            Description = "A man must struggle to travel home for Thanksgiving with a lovable oaf of a shower curtain ring salesman as his only companion.",
                            Director = "John Hughes",
                            GenreId = 4,
                            Image = "https://m.media-amazon.com/images/M/MV5BMjE4MzI2MTY5MF5BMl5BanBnXkFtZTcwOTY2NTA0OQ@@._V1_.jpg",
                            ReleaseYear = "1987",
                            Title = "Planes, Trains, & Automobiles",
                            Writer = "John Hughes"
                        },
                        new
                        {
                            Id = 6,
                            Description = "A small-time boxer gets a supremely rare chance to fight a heavyweight champion in a bout in which he strives to go the distance for his self-respect.",
                            Director = "John G. Avildsen",
                            GenreId = 6,
                            Image = "https://m.media-amazon.com/images/M/MV5BMTY5MDMzODUyOF5BMl5BanBnXkFtZTcwMTQ3NTMyNA@@._V1_.jpg",
                            ReleaseYear = "1976",
                            Title = "Rocky",
                            Writer = "Slyvester Stallone"
                        });
                });

            modelBuilder.Entity("Movies.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AverageRating")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfReviews")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalRatings")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AverageRating = 0,
                            Comment = "Great movie.  Fun!",
                            MovieId = 1,
                            NumberOfReviews = 0,
                            Rating = 5,
                            ReviewerName = "Cheese",
                            TotalRatings = 0
                        },
                        new
                        {
                            Id = 2,
                            AverageRating = 0,
                            Comment = "The best!  A Christmas classic.",
                            MovieId = 2,
                            NumberOfReviews = 0,
                            Rating = 5,
                            ReviewerName = "Mike",
                            TotalRatings = 0
                        },
                        new
                        {
                            Id = 3,
                            AverageRating = 0,
                            Comment = "I coulda been at a barbeque!!!",
                            MovieId = 3,
                            NumberOfReviews = 0,
                            Rating = 4,
                            ReviewerName = "Lisa",
                            TotalRatings = 0
                        });
                });

            modelBuilder.Entity("Movies.Models.Movie", b =>
                {
                    b.HasOne("Movies.Models.Genre", "Genre")
                        .WithMany("Movie")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Movies.Models.Review", b =>
                {
                    b.HasOne("Movies.Models.Movie", "Movie")
                        .WithMany("Review")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Movies.Models.Genre", b =>
                {
                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Movies.Models.Movie", b =>
                {
                    b.Navigation("Review");
                });
#pragma warning restore 612, 618
        }
    }
}
