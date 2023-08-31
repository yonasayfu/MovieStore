using MovieStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Application
{
    internal interface IMovieService
    {
        Movie GetMovieByID(int id);
        IEnumerable<Movie> GetAllMovies();
        void AddMovie(Movie movie);
       
    }
}
