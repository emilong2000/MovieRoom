using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Domain.Models;
using Movies.Infastructure.IService;

namespace Movies.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpPost]
        public async Task<ApiResponse> CreateMovie([FromForm] MovieRequest model)
        {
            return await _movieService.CreateMovie(model);
        }

        [HttpPut]
        public async Task<ApiResponse> UpdateMovie([FromForm] MovieUpdateRequest model)
        {
            return await _movieService.EditMovie(model);
        }

        [HttpGet]
        public async Task<ApiResponse> GetMovie()
        {
            return await _movieService.GetAllMovies();
        }

        [HttpDelete]
        public async Task<ApiResponse> DeleteMovie(int Id)
        {
            return await _movieService.DeleteMovie(Id);
        }
    }
}
