using BookingManagerService.Entities;
using BookingManagerService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingManagerService.DataService
{
   public interface IBookingRepository
    {
        int BookMovieInMultiplex(BookingDto bookingDto);

        Booking GetBooking(int id);

        List<string> GetBookings(int movieId, string date);
        bool Save();
    }
}
