using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookingManagerService.DTO;
using BookingManagerService.DataService;
using BookingManagerService.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookingManagerService.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Roles = Role.Customer)]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IBookingService _bookingService;

        public BookingController(IBookingRepository bookingRepository, IBookingService bookingService)
        {
            _bookingRepository = bookingRepository;
            _bookingService = bookingService;
        }

        [Route("availableSeats")]
        public IActionResult AvailableSeats(int movieId, string date)
        {
            //Fetch the existing bookings for the movieID
            List<string> bookedSeats = _bookingRepository.GetBookings(movieId, date);
            //Determine avaiable seats for the movie
            string availableSeats = _bookingService.AvailableSeats(_bookingService.GetBookedSeats(bookedSeats));
            return Ok(availableSeats);
        }

        [HttpPost]
        [Route("book")]
        public IActionResult BookMovie([FromBody] BookingDto booking)
        {
            if (booking == null)
                return BadRequest();
            if (!ModelState.IsValid)
                return BadRequest();
            if (booking.SeatNo.Split(',').Count() > 5)
                return StatusCode(405, new { message = "More than 5 seats are not allowed." });

            int bookedId = _bookingRepository.BookMovieInMultiplex(booking);
            if (bookedId <= 0)
                return StatusCode(500, "A problem happened while handling your request");

            return Created("bookingDetails", new { id = bookedId });

        }

        [HttpGet]
        [Route("bookingDetails")]
        public IActionResult BookingDetails(int id)
        {
            if (id <= 0)
                return BadRequest();
            var booking = _bookingRepository.GetBooking(id);
            if (booking == null)
                return NotFound();
            BookingDto results = new BookingDto { Amount = booking.Amount, DateToPresent = Convert.ToString(booking.DateToPresent), MovieId = booking.MovieId, SeatNo = booking.SeatNo, UserId = booking.SeatNo };
            return Ok(results);

        }
    }
}
