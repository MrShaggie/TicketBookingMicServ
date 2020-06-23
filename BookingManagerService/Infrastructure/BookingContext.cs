using BookingManagerService.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingManagerService.Infrastructure
{
    public class BookingContext : DbContext
    {
        public BookingContext(DbContextOptions<BookingContext> options) : base(options)
        {
            Database.Migrate();
        }
        
        public DbSet<City> Cities { get; set; }
        public DbSet<Multiplex> Multiplexes { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Booking> Bookings { get; set; }
    }
}
