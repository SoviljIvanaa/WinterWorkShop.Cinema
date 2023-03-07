using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.Data.Repositories
{
    public interface IProjectionsRepository
    {
        List<Projections> GetAllProjections();

        Projections GetProjectionById(int id);
        Projections GetProjectionsByMovieId(int id);
    }
}
