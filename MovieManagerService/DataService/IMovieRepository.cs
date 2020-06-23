using MovieManagerService.Entities;
using MovieManagerService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieManagerService.DataService
{
    public interface IMovieRepository
    {
        IEnumerable<City> GetCities();

        IEnumerable<Multiplex> GetMultiplexes(int cityId);

        IEnumerable<Movie> GetMovies(int multiplexId);

        IEnumerable<Movie> GetMovies(string language);

        int AddMovies(MovieDto movieDto);

        IEnumerable<Movie> GetMoviesByGenre(string genre);
    }
}
