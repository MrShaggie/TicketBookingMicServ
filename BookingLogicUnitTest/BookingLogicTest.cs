using NUnit.Framework;
using System.Collections.Generic;

namespace BookingLogicUnitTest
{
    [TestFixture]
    public class Tests
    {
        List<string> bookedSeats = new List<string>();
        List<int> expectSeats = new List<int>();

        [SetUp]
        public void Setup()
        {
            bookedSeats.Add("1,2,3,4,5");
            bookedSeats.Add("6,7,8");
            
            expectSeats.Add(1);
            expectSeats.Add(2);
            expectSeats.Add(3);
            expectSeats.Add(4);
            expectSeats.Add(5);
            expectSeats.Add(6);
            expectSeats.Add(7);
            expectSeats.Add(8);
        }

        [Test]
        public void Test_BookedSeats()
        {
            var bookingLogic = new BookingManagerService.DataService.BookingLogic();
            List<int> actualSeats = bookingLogic.GetBookedSeats(bookedSeats);

            Assert.AreEqual(expectSeats, actualSeats);
        }

        [Test]
        public void Test_AvailableSeats()
        {
            List<int> bookedSeats = new List<int>();
            bookedSeats.Add(1);
            bookedSeats.Add(2);
            bookedSeats.Add(3);
            bookedSeats.Add(4);
            bookedSeats.Add(5);
            bookedSeats.Add(6);
            bookedSeats.Add(7);
            bookedSeats.Add(8);

            string expectedResult = "9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51," +
                "52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100";

            var bookingLogic = new BookingManagerService.DataService.BookingLogic();
            string str = bookingLogic.AvailableSeats(bookedSeats);

            Assert.AreEqual(expectedResult, str);
        }
    }
}