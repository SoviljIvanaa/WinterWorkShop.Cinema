using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Domain.Common
{
    public class Database
    {
        public List<MovieModel> GetAllMoviesResponses = new List<MovieModel> 
        { 
            new MovieModel { Id = 1, Name = "Spiderman"},
            new MovieModel { Id = 2, Name = "Spiderman 2"}
        };

        public List<ProjectionModel> GetAllProjectionsResponses = new List<ProjectionModel>
        {
            new ProjectionModel { Id = 1, Date = new DateTime(2023, 1, 1) },
            new ProjectionModel { Id = 2, Date = new DateTime(2023, 1, 2)}
        };
    }
}