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
            var projection = _database.GetAllProjectionsResponses.FirstOrDefault(p => p.Id == id);
           
            return projection == null ? throw new Exception("Projection not found") : projection;
        }

        public List<ProjectionsModel> GetProjectionsByMovieId(int movieId)
        {
            var projections = _database.GetAllProjectionsResponses.Where(p => p.MovieId == movieId).ToList();

            return projections.Count == 0 ? throw new Exception("Movie has no projections") : projections;
        }
    }
}
