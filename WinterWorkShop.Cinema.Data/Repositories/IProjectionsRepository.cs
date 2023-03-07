using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public interface IProjectionsRepository
    {
        public List<ProjectionsModel> GetAllProjections();

        public ProjectionsModel GetProjectionById(int id);
        public List<ProjectionsModel> GetProjectionsByMovieId(int movieId);
    }
}
