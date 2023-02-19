using System;
using Microsoft.EntityFrameworkCore;

namespace Mission6_sunny28.Models
{
    public class MovieContex : DbContext
    {
        public MovieContex(DbContextOptions<MovieContex> options) : base (options)
        {
        }

        public DbSet<Movie> responses { get; set; }


        //automatically add movies to database on creation
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Category = "Action/Adventure",
                    Title = "Black Panther",
                    Year = 2018,
                    Director = "Ryan Coogler",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new Movie
                {
                    MovieId = 2,
                    Category = "Musical/Romance",
                    Title = "The Phantom of the Opera",
                    Year = 2005,
                    Director = "Joel Schumacher",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new Movie
                {
                    MovieId = 3,
                    Category = "Mystery/Animation",
                    Title = "Detective Conan: Full Score of Fear",
                    Year = 2008,
                    Director = "Yasuichiro Yamamoto",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new Movie
                {
                    MovieId = 4,
                    Category = "Romance/Fantasy",
                    Title = "Your Name.",
                    Year = 2016,
                    Director = "Makoto Shinkai",
                    Rating = "PG",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                }
                );
        }
    }
}
