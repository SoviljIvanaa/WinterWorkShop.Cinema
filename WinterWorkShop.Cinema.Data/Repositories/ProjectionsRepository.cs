using WinterWorkShop.Cinema.Data.Exceptions;
using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Domain.Common;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public class ProjectionsRepository : IProjectionsRepository
    {
        public Database Database = new Database();

        public List<Projections> GetAllProjections()
        {
            return Database.GetAllProjectionsResponses;
        }
        public Projections GetProjectionById(int id)
        {
            var result = Database.GetAllProjectionsResponses.FirstOrDefault(u => u.Id == id);

            return result;
        }

        public Projections GetProjectionsByMovieId(int id)
        {
            var result = Database.GetAllProjectionsResponses.FirstOrDefault(u => u.MoviesId == id);
            if(result == null)
            {
                throw new NotFoundException(id);
            }

            return result;
        }
    }
}
