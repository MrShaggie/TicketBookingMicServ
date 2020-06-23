using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingManagerService.Infrastructure;
using BookingManagerService.Entities;
using BookingManagerService.DTO;

namespace BookingManagerService.DataService
{
    public class BookingRepository : IBookingRepository
    {
        private readonly BookingContext _bookingContext;
        public BookingRepository(BookingContext bookingContext)
        {
            _bookingContext = bookingContext;
        }
        public int BookMovieInMultiplex(BookingDto bookingDto)
        {
            Booking newBooking = new Booking { MovieId = bookingDto.MovieId, Amount = bookingDto.Amount, SeatNo = bookingDto.SeatNo, UserId = bookingDto.UserId, DateToPresent = Convert.ToDateTime(bookingDto.DateToPresent) };
            _bookingContext.Bookings.Add(newBooking);
            _bookingContext.SaveChanges();
            return newBooking.Id;


        }

        public List<string> GetBookings(int movieId, string date)
        {
             return _bookingContext.Bookings.Where(x => x.MovieId == movieId 
                        && x.DateToPresent.ToShortDateString() == Convert.ToDateTime(date).ToShortDateString()).Select(c => c.SeatNo).ToList();
        }

        public Booking GetBooking(int id)
        {
          return _bookingContext.Bookings.Where(x => x.Id == id).FirstOrDefault();
        }

        public bool Save()
        {
            return (_bookingContext.SaveChanges() >= 0);
        }
    }
}
