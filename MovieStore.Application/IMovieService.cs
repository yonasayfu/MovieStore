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
        //Comments for to see the git change
        // I Update the Second times
        Movie GetMovieByID(int id);
        IEnumerable<Movie> GetAllMovies();
        void AddMovie(Movie movie);
       
    }
}
