﻿using WinterWorkShop.Cinema.Data.Models;

namespace WinterWorkShop.Cinema.Domain.Common
{
    public class Database
    {
        public List<MovieModel> GetAllMoviesResponses = new List<MovieModel> 
        { 
            new MovieModel { Id = 1, Name = "Spuderman" },
            new MovieModel { Id = 2, Name = "Spuderman 2"}
        };

        public List<Projections> GetAllProjectionsResponses = new List<Projections>
        {
            new Projections { Id = 1, Name = "Iron Man", MoviesId = 1 },
            new Projections { Id = 2, Name = "Iron Man 2", MoviesId = 1},
            new Projections { Id = 3, Name = "Avengers", MoviesId = 2}
        };
    }
}
