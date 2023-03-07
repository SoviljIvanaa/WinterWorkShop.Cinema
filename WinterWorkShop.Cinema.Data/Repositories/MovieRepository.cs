using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Domain.Common;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public Database Database = new Database();

        public List<MovieModel> GetAllMovies()
        {
            return Database.GetAllMoviesResponses;
        }

        public MovieModel GetMovieById(int idMovieSample) 
        {
            var getMovie = GetAllMovies().FirstOrDefault(MovieModel => MovieModel.Id == idMovieSample);

            if(getMovie is null)
            {
                throw new Exception(idMovieSample + " does not exist.");
            }

            return getMovie;
        }
    }
}
