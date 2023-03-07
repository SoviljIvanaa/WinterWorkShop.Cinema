using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Domain.Common;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public class ProjectionsRepository : IProjectionsRepository
    {
        public Database Database = new Database();

        public List<Projections> GetAllProjections()
        {
            return Database.GetAllProjectionsResponses;
        }
        public Projections GetProjectionsById(int id)
        {
            var result = Database.GetAllProjectionsResponses.Where(u => u.Id == id).FirstOrDefault();

            return result;
        }

    }
}
