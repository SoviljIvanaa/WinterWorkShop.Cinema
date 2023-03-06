using Microsoft.AspNetCore.Mvc;
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
        
        /*public List<GetAllMoviesResponse> GetMovies()
        {
            var movies = _movieRepository.GetAllMovies();

            var result = new List<GetAllMoviesResponse>();

            foreach(var movie in movies)
            {
                result.Add(new GetAllMoviesResponse
                {
                    Id = movie.Id,
                    Name = movie.Name
                });
            }

            return result;
        }*/

        public List<GetAllMoviesResponse> GetMovieWithId()
        {
            var movieById = _movieRepository.GetMovieById(1);

            var resultById = new List<GetAllMoviesResponse>();

            resultById.Add(new GetAllMoviesResponse 
            { 
                Id = movieById.Id,
                Name = movieById.Name   
            });

            return resultById;
        }
    }
}