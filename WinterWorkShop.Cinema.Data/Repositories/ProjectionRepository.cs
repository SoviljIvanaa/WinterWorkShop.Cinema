using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Domain.Common;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public class ProjectionRepository : IProjectionRepository
    {
        public Database Database = new Database();

        public List<ProjectionModel> GetAllProjections()
        {
            return Database.GetAllProjectionsResponses;
        }

        public ProjectionModel GetProjectionById(int idProjectionSample)
        {
            return GetAllProjections().FirstOrDefault(ProjectionModel => ProjectionModel.Id == idProjectionSample);
        }
    }
}
