using IRDb.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IRDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository context)
        {
            _movieRepository = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Movie>>> GetAllMovies()
        {
            return await _movieRepository.GetAllMovies();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetSingleMovie(int id)
        {
            var result = await _movieRepository.GetSingleMovie(id);
            if (result == null)
                return NotFound("Movie not found!");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Movie>>> AddMovie(Movie movie)
        {
            var result = await _movieRepository.AddMovie(movie);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<Movie>>> UpdateMovie(int id, Movie request)
        {
            var result = await _movieRepository.UpdateMovie(id, request);
            if (result == null)
                return NotFound("Movie not found!");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Movie>>> DeleteMovie(int id)
        {
            var result = await _movieRepository.DeleteMovie(id);
            if (result == null)
                return NotFound("Movie not found!");
            return Ok(result);
        }
    }
}
