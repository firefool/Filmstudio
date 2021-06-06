using Filmstudio.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Filmstudio.Data.Interfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie GetMovie(Guid id);
    }
}
