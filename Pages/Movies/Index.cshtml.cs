using IRDb.Database;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IRDb.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieDbContext _context;

        public List<Movie> Movies { get; set; } = new();

        public IndexModel(MovieDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Movies = _context.Movies.OrderBy(m => m.Title).ToList();
        }
    }
}
