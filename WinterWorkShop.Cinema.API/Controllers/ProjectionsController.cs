using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Responses;
using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    
    public class ProjectionsController : BaseController
    {

        public readonly IProjectionRepository _projectionRepository;

        public ProjectionsController(IProjectionRepository projectionRepository)
        {
            _projectionRepository = projectionRepository;
        }

        [HttpGet("projection")]
        public List<GetAllProjectionsResponse> GetProjections()
        {
            var projections = _projectionRepository.GetAllProjections();
            var result = new List<GetAllProjectionsResponse>();
            foreach (var projection in projections)
            {
                result.Add(new GetAllProjectionsResponse { Id = projection.Id, Time = projection.Time });
            }

            return result;
        }


        [HttpGet("projection/{id}")]
        public ProjectionModel GetProjection(int id)
        {
            var projection = _projectionRepository.GetProjectionById(id);
            return projection;
        }

        [HttpGet("projection/{movieId:int}")]
        public ProjectionModel GetProjectionByMovie(int movieId)
        {
            var projection = _projectionRepository.GetProjectionByMovieId(movieId);
            return projection;
        }
    }
}
