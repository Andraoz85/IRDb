using IRDb.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IRDb.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly IMovieRepository _movieRepository;

        public DetailsModel(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie? Movie { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            Movie = await _movieRepository.GetSingleMovie(id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}