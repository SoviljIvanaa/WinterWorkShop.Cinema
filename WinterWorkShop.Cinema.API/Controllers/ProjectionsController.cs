using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.Domain.Responses;
using WinterWorkShop.Cinema.Domain.Common;
using WinterWorkShop.Cinema.API.Models;
using WinterWorkShop.Cinema.Data.Repositories;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    [Route("projections")]
    public class ProjectionsController : BaseController
    {
        public readonly IProjectionRepository _projectionsRepository;
        public ProjectionsController(IProjectionRepository projectionsRepository)
        {
            _projectionsRepository = projectionsRepository;
        }

        [HttpGet()]
        public List<ProjectionResponse> GetProjections()
        {
            var projections = _projectionsRepository.GetAllProjections();

            var result = new List<ProjectionResponse>();

            foreach (var projection in projections)
            {
                result.Add(new ProjectionResponse
                {
                    Id = projection.Id,
                    ProjectionDate = projection.ProjectionDate,
                    ProjectionName = projection.ProjectionName
                });
            }

            return result;
        }

    }   
}