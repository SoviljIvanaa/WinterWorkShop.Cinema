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

        public MovieModel GetMovieById(int id)
        {
            var movieModel = Database.GetAllMoviesResponses.FirstOrDefault(m => m.Id == id);

            return movieModel == null ? throw new Exception("Movie not found.") : movieModel;
        }
    }
}
