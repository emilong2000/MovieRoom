using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Core.Services;
using Movies.Domain.Models;
using Movies.Infastructure.IService;

namespace Movies.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService _genreService;
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }


        [HttpPost]
        public async Task<ApiResponse> CreateGenre([FromBody] GenreRequest model)
        {
            return await _genreService.CreateGenre(model);
        }

        [HttpPut]
        public async Task<ApiResponse> UpdateMovie([FromBody] Genre model)
        {
            return await _genreService.EditGenre(model);
        }

        [HttpGet]
        public async Task<ApiResponse> GetMovie()
        {
            return await _genreService.GetAllGenres();
        }
    }
}
