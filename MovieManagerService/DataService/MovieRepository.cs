using MovieManagerService.DTO;
using MovieManagerService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieManagerService.DataService
{
    public class MovieRepository : IMovieRepository
    {
        public int AddMovies(MovieDto movieDto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetCities()
        {
            throw new NotImplementedException();
        }

        public Movie GetMovieDetails(int movieId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetMovies(int multiplexId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetMovies(string language)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Multiplex> GetMultiplexes(int cityId)
        {
            throw new NotImplementedException();
        }
    }
}
