using IRDb.Repositories;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IRDb.Pages.Movies
{
    public class UpdateModel : PageModel
    {
        private readonly IMovieRepository _movieRepository;
        public List<Movie> Movies { get; set; }

        public UpdateModel(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
            Movies = new List<Movie>();
        }

        public async Task OnGetAsync()
        {
            Movies = await _movieRepository.GetAllMovies();
        }
    }
}