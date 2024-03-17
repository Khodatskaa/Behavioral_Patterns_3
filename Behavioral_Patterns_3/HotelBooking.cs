using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Patterns_3
{
    public class HotelBooking : IBooking
    {
        public void Book()
        {
            Console.WriteLine("Hotel booked successfully!");
        }
    }
}
