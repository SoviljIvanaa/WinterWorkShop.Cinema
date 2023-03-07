using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.Data.Models;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Common;
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
        public GetAllProjectionsResponse GetProjectionById(int id)
        {
            var projection = _projectionsRepository.GetProjectionById(id);

            var result = new GetAllProjectionsResponse();

            result.Id = projection.Id;

            result.Name = projection.Name;

            return result;
        }

        [HttpGet("projections/movies/{movie_id}")]
        public GetAllProjectionsResponse GetProjectionsByMovieId([FromRoute(Name ="movie_id")]int id)
        {
            var movies = _projectionsRepository.GetProjectionsByMovieId(id);

            var result = new GetAllProjectionsResponse();

            result.Id = movies.Id;
            result.Name = movies.Name;

            return result;
        }
    }
}
