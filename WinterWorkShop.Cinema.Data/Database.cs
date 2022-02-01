using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Data
{
    public class Database
    {
        public List<MovieModel> GetAllMoviesResponses = new List<MovieModel>
        {
            new MovieModel { Id = 1, Name = "Spuderman 1" },
            new MovieModel { Id = 2, Name = "Spuderman 2"}
        };
        public List<ProjectionModel> GetallProjectionsResponses = new List<ProjectionModel>
        {
            new ProjectionModel {ProjectionDate = DateTime.Now, ProjectionName = "Projekcija 1"},
            new ProjectionModel {ProjectionDate = DateTime.Now, ProjectionName = "Projekcija 2"}
        };
    }
}
