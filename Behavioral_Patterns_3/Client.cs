using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public class Client
    {
        private TravelBooking bookingSystem = new TravelBooking();

        public void BookTravel()
        {
            bookingSystem.AddBookingStrategy("flight", new FlightBooking());
            bookingSystem.AddBookingStrategy("hotel", new HotelBooking());
            bookingSystem.AddBookingStrategy("car", new CarRentalBooking());

            bookingSystem.Book("flight");
            bookingSystem.Book("hotel");
            bookingSystem.Book("car");
        }
    }
}
