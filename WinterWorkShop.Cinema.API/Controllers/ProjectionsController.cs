using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    public class ProjectionsController : BaseController
    {
        public readonly IProjectionsRepository _projectionsRepository;

        public ProjectionsController(IProjectionsRepository projectionsRepository)
        {
            _projectionsRepository = projectionsRepository;
        }

        [HttpGet("projections")]
        public List<GetAllProjectionsResponse> GetProjections()
        {
            var projections = _projectionsRepository.GetAllProjections();

            var result = new List<GetAllProjectionsResponse>();

            foreach (var projection in projections)
            {
                result.Add(new GetAllProjectionsResponse
                {
                    Id = projection.Id,
                    Name = projection.Name
                });
            }

            return result;
        }

        [HttpGet("projections/{id}")]
        public Projections GetProjectionsById(int id)
        {
            var projections = _projectionsRepository.GetProjectionsById(id);

            return projections;
        }
    }
}
