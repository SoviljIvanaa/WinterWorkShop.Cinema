using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Domain.Common
{
    public class Database
    {
        public List<MovieModel> GetAllMoviesResponses = new List<MovieModel> 
        { 
            new MovieModel { Id = 1, Name = "Spuderman" },
            new MovieModel { Id = 2, Name = "Spuderman 2"}
        };

        public List<ProjectionModel> getAllProjectionsResponse = new List<ProjectionModel> 
        {
            new ProjectionModel { Id = 1, Time = 2000, MovieId = 1},
            new ProjectionModel { Id = 2, Time = 1900, MovieId = 2}
        };

    }
}
