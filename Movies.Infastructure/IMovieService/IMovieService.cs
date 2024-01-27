using Movies.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Infastructure.IService
{
    public interface IMovieService
    {
        Task<ApiResponse> CreateMovie(MovieRequest model);
        Task<ApiResponse> EditMovie(MovieUpdateRequest model);
        Task<ApiResponse> GetAllMovies();
        Task<ApiResponse> DeleteMovie(int Id);

    }
}
