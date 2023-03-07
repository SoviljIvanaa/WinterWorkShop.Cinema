using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.API.Controllers;
using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    public class MoviesController : BaseController
        {
                public readonly IMovieRepository _movieRepository;

        public MoviesController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet("movies")]
        
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

        [HttpGet("movies/{id}")]
        public MovieModel GetMoviesById(int id)
        {
            var movies = _movieRepository.GetMoviesById(id);

            return movies;
        }
    }
}