using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Domain.Common;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public class ProjectionsRepository : IProjectionsRepository
    {
        public Database _database = new Database();
        public List<ProjectionsModel> GetAllProjections()
        {
            return _database.GetAllProjectionsResponses;
        }

        public ProjectionsModel GetProjectionById(int id)
        {
            return _database.GetAllProjectionsResponses.FirstOrDefault(p => p.Id == id);
        }

        public List<ProjectionsModel> GetProjectionByMovieId(int movieId)
        {
            return _database.GetAllProjectionsResponses.Where(p => p.MovieId == movieId).ToList();
        }
    }
}
