using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.API.Controllers;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    [Route("movies")]
    public class MoviesController : BaseController
        {
                public readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet()]
        public List<GetAllMoviesResponse> GetMovies()
        {
            var movies = _movieRepository.GetAllMovies();

            var result = new List<GetAllMoviesResponse>();

            foreach (var movie in movies)
            {
                result.Add(new GetAllMoviesResponse
                {
                    Id = movie.Id,
                    Name = movie.Name
                });
            }

            return result;
        }
    }
}