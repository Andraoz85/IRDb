namespace IRDb.Repositories
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllMovies();
        Task<Movie?> GetSingleMovie(int id);
        Task<List<Movie>> AddMovie(Movie movie);
        Task<List<Movie>?> UpdateMovie(int id, Movie request);
        Task<List<Movie>?> DeleteMovie(int id);
        Task<Movie> GetMovieById(int id);
    }
}
