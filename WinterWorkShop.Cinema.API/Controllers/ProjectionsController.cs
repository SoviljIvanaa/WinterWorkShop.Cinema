﻿using Microsoft.AspNetCore.Mvc;
using WinterWorkShop.Cinema.API.Models;
using WinterWorkShop.Cinema.Data.Repositories;
using WinterWorkShop.Cinema.Domain.Common;
using WinterWorkShop.Cinema.Domain.Responses;

namespace WinterWorkShop.Cinema.API.Controllers
{
    [ApiController]
    [Route("projections")]
    public class ProjectionsController : BaseController
    {
        public readonly IProjectionRepository _projectionRepository;

        public ProjectionsController(IProjectionRepository projectionRepository)
        {
            _projectionRepository = projectionRepository;
        }

        [HttpGet()]
        public List<ProjectionResponse> GetMovies()
        {
            var projections = _projectionRepository.GetAllProjections();

            var result = new List<ProjectionResponse>();

            foreach (var projection in projections)
            {
                result.Add(new ProjectionResponse
                {
                    Id = projection.Id,
                    ProjectionDate = DateTime.Now,
                    CinemaName = projection.CinemaName,
                    MovieName = projection.MovieName
                });
            }

            return result;
        }

        [HttpGet("{id}")]
        public ActionResult<ProjectionResponse> GetMovieById(int id)
        {
            var projection = _projectionRepository.GetProjectionById(id);

            if (projection == null)
            {
                ErrorResponseModel errorResponse = new ErrorResponseModel()
                {
                    ErrorMessage = Messages.MOVIE_DOES_NOT_EXIST,
                    StatusCode = System.Net.HttpStatusCode.NotFound
                };
                return NotFound(errorResponse);
            }

            var result = new ProjectionResponse()
            {
                Id = id,
                ProjectionDate = DateTime.Now,
                CinemaName = projection.CinemaName,
                MovieName = projection.MovieName
            };

            return result;
        }
    }
}