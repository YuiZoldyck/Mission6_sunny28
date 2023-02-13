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
    }
}
