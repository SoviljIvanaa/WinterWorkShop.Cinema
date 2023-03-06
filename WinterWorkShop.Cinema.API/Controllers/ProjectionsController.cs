using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    [Route("projections")]
    public class ProjectionsController : BaseController
    {
        public ProjectionsController(IProjectionsRepository projectionsRepository)
        {
            _projectionsRepository = projectionsRepository;
        }

        public readonly IProjectionsRepository _projectionsRepository;

        [HttpGet()]
        public List<GetAllProjectionsResponse> Index()
        {
            var projections = _projectionsRepository.GetAllProjections();

            var result = new List<GetAllProjectionsResponse>();

            foreach(var projection in projections)
            {
                result.Add(new GetAllProjectionsResponse
                {
                    Id = projection.Id,
                    Name = projection.Name
                });

            }
            return result;
        }
        [HttpGet("{id}")]
        public GetProjectionByIdResponse GetProjectionById(int id)
        {
            var projection = _projectionsRepository.GetProjectionById(id);

            var result = new GetProjectionByIdResponse  { Id = projection.Id, Name = projection.Name };


            return result;
        }

        [HttpGet("GetProjectionByMovieId/{id}")]
        public List<GetProjectionsByMovieId> GetProjectionByMovieId(int id)
        {
            var projections = _projectionsRepository.GetProjectionByMovieId(id);

            var result = new List<GetProjectionsByMovieId>();
			foreach (var projection in projections)
				{
					result.Add(new GetProjectionsByMovieId
					{
						Id = projection.Id, 
                        Name = projection.Name,
					});

				}


			return result;
        }
    }
}
