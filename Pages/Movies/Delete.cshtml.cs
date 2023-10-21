using IRDb.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IRDb.Pages.Movies // Ändra detta till det faktiska namnrymden för din Razor-sida
{
    public class DeleteModel : PageModel
    {
        private readonly IMovieRepository _movieRepository;

        public DeleteModel(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
            Movies = new List<Movie>();
        }

        public List<Movie> Movies { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Movies = await _movieRepository.GetAllMovies();
            return Page();
        }
    }
}
