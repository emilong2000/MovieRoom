using Movies.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Infastructure.IService
{
    public interface IGenreService
    {
        Task<ApiResponse> CreateGenre(GenreRequest model);
        Task<ApiResponse> EditGenre(Genre model);
        Task<ApiResponse> GetAllGenres();
    }
}
