using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public class ProjectionRepository : IProjectionRepository
    {
        public Database Database = new Database();

        public List<ProjectionModel> GetAllProjections()
        {
            return Database.GetAllProjectionsResponses;
        }
        public ProjectionModel GetProjectionById(int id)
        {
            var projection = Database.GetAllProjectionsResponses.FirstOrDefault(x => x.Id == id);

            return projection;
        }
        public List<ProjectionModel> GetProjectionsByMovieId(int id)
        {
            return Database.GetAllProjectionsResponses.Where(x => x.MovieId == id).ToList();
        }
    }
}
