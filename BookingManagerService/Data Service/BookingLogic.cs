using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingManagerService.DataService
{
    public class BookingLogic : IBookingService
    {
        public List<int> GetBookedSeats(List<string> bookedSeats)
        {
           
            List<int> lstBooked = new List<int>();
            foreach(String str in bookedSeats)
            {
                string[] booked = str.Split(','); 
                foreach(string s in booked)
                {
                    lstBooked.Add(Convert.ToInt32(s));
                }
            }
            return lstBooked;
        }

        public String AvailableSeats(List<int> bookedNumbers)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i <= 100; i++)
            {
                if (!bookedNumbers.Contains(i))
                {
                    sb.Append(Convert.ToString(i));
                    if(i!=100)
                    sb.Append(',');
                }
            }
            return sb.ToString();
        }
    }
}
