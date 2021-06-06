using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmstudioAPI;
using Filmstudio.Data.Models;
using Filmstudio.Data.Interfaces;
using Filmstudio.Data.Repository;

namespace FilmstudioAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private MovieRepository movies = new MovieRepository();

        [HttpGet]
        public ActionResult<IEnumerable<Movie>> GetAllMovies()
        {
            return movies.GetAllMovies();
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetMovie(Guid id)
        {
            var movie = movies.GetMovie(id);
            if(movie == null)
            {
                return NotFound();
            }
            return movie;
        }

    }
}
