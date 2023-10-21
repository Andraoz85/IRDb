using IRDb.Database;
using Microsoft.EntityFrameworkCore;

namespace IRDb.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;

        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }


        public async Task<List<Movie>> AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return await _context.Movies.ToListAsync();
        }

        public async Task<List<Movie>?> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
                return null;

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return await _context.Movies.ToListAsync();
        }

        public async Task<List<Movie>> GetAllMovies()
        {
            var movies = await _context.Movies.ToListAsync();
            return movies;
        }

        public Task<Movie> GetMovieById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Movie?> GetSingleMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
                return null;

            return movie;
        }

        public async Task<List<Movie>?> UpdateMovie(int id, Movie request)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
                return null;

            movie.Title = request.Title;
            movie.Genre = request.Genre;
            movie.Rating = request.Rating;
            movie.Year = request.Year;


            await _context.SaveChangesAsync();

            return await _context.Movies.ToListAsync();
        }
    }
}
