using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public class TravelBooking
    {
        private Dictionary<string, IBooking> bookingStrategies = new Dictionary<string, IBooking>();

        public void Book(string bookingType)
        {
            if (bookingStrategies.ContainsKey(bookingType))
            {
                bookingStrategies[bookingType].Book();
            }
            else
            {
                Console.WriteLine($"No booking strategy found for {bookingType}.");
            }
        }

        public void AddBookingStrategy(string bookingType, IBooking booking)
        {
            bookingStrategies.Add(bookingType, booking);
        }

        public void RemoveBookingStrategy(string bookingType)
        {
            bookingStrategies.Remove(bookingType);
        }

        public void ClearBookingStrategies()
        {
            bookingStrategies.Clear();
        }

        public void PrintBookingStrategies()
        {
            foreach (var booking in bookingStrategies)
            {
                Console.WriteLine(booking.Key);
            }
        }
    }
}
