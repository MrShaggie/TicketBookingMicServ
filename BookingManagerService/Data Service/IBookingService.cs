using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingManagerService.DataService
{
    public interface IBookingService
    {
        List<int> GetBookedSeats(List<string> bookedSeats);
        String AvailableSeats(List<int> bookedNumbers);
    }
}
