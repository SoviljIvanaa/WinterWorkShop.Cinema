using Microsoft.AspNetCore.Mvc;
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
        public List<GetAllProjectionsResponse> GetAllProjections()
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

        [HttpGet("GetProjectionsByMovieId/{id}")]
        public List<GetProjectionsByMovieIdResponse> GetProjectionsByMovieId(int id)
        {
            var projections = _projectionsRepository.GetProjectionsByMovieId(id);

            var result = new List<GetProjectionsByMovieIdResponse>();
			foreach (var projection in projections)
				{
					result.Add(new GetProjectionsByMovieIdResponse
					{
						Id = projection.Id, 
                        Name = projection.Name,
					});

				}


			return result;
        }
    }
}
