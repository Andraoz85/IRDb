using Microsoft.EntityFrameworkCore;

namespace IRDb.Database
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<Movie>().HasData(new Movie()
            {
                Id = 1,
                Title = "Matrix",
                Year = 1999,
                Genre = "Action",
                Rating = Math.Round(7.8, 1)
            },
            new Movie
            {
                Id = 2,
                Title = "The Silence of the Lambs",
                Year = 1991,
                Genre = "Thriller",
                Rating = Math.Round(8.6, 1)
            },
            new Movie
            {
                Id = 3,
                Title = "One Flew Over the Cuckoo's Nest",
                Year = 1975,
                Genre = "Drama",
                Rating = Math.Round(8.7, 1)
            });
        }
    }
}