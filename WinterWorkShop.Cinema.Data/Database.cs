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

        public List<ProjectionsModel> GetAllProjectionsResponses = new List<ProjectionsModel>()
        {
            new ProjectionsModel { Id = 1, Name = "Projection 1"},
            new ProjectionsModel { Id = 2, Name = "Projection 2"}
        };
    }
}
