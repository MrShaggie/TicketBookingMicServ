using Microsoft.EntityFrameworkCore;
using MovieManagerService.Entities;

namespace MovieManagerService.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Multiplex> Multiplexes { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
