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

        public MovieModel GetMoviesById(int id)
        {
            var result = Database.GetAllMoviesResponses.Where(u => u.Id == id).FirstOrDefault();

            return result;
        }
    }
}
