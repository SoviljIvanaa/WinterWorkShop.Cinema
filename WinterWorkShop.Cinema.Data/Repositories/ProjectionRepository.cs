using WinterWorkShop.Cinema.Data.Exceptions;
using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Domain.Common;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public class ProjectionRepository : IProjectionRepository
    {
        public Database Database = new Database();
        public List<ProjectionModel> GetAllProjections()
        {
            return Database.getAllProjectionsResponse;
        }


        public ProjectionModel GetProjectionById(int id)
        {
            var result =  Database.getAllProjectionsResponse.FirstOrDefault(p => p.Id == id);  
            return result;
        }

        public ProjectionModel GetProjectionByMovieId(int movieId)
        {
            var result = Database.getAllProjectionsResponse.FirstOrDefault(p => p.MovieId == movieId);
            return result ?? throw new ProjectionNotFoundException(movieId);
        }
    }
}
