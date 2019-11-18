using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_secao11_aula142.Entities
{
    class Reservation
    {
        public int roomNumber { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            this.roomNumber = roomNumber;
            this.checkin = checkin;
            this.checkout = checkout;
        }
        public int duration()
        {
            TimeSpan duration = checkout.Subtract(checkin);
            return (int)duration.TotalDays;
        }
    }
}
