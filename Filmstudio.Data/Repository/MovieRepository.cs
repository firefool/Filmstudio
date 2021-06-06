using Filmstudio.Data.Interfaces;
using Filmstudio.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Filmstudio.Data.Repository
{
    public class MovieRepository : IMovieRepository
    {

        public List<Movie> movies = new List<Movie>()
        {
            new Movie { Title = "Test", Director = "Lasse", OriginCountry = "Sweden", ReleaseYear = 2001 },
            new Movie { Title = "Test2", Director = "Pelle", OriginCountry = "Sweden", ReleaseYear = 2004 },
            new Movie { Title = "Test3", Director = "Hans", OriginCountry = "Sweden", ReleaseYear = 2008 },
            new Movie { Title = "Test4", Director = "Lasse", OriginCountry = "Sweden", ReleaseYear = 2011 }
        };
        public List<Movie> GetAllMovies()
        {
            return movies;
        }

        public Movie GetMovie(Guid id)
        {
            return movies.FirstOrDefault(x => x.Id == id);
        }
    }
}
