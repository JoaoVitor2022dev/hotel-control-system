using System;
using System.Globalization;

namespace Program.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set;}
        public DateTime CheckOut { get; set; }
        public Reservation()
        {}
        public Reservation(int roomNumber,DateTime checkin, DateTime checkOut)
        {
            RoomNumber = roomNumber; 
            CheckIn = checkin; 
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan durantion = CheckOut.Subtract(CheckIn);
            return (int)durantion.TotalDays;
        }
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
           CheckIn = checkin; 
           CheckOut = checkout;
        }
        public override string ToString()
        {
            return "Room" 
            + RoomNumber
            + "Check-in: "
            + CheckIn.ToString("DD/MM/YYYY")
            + "Check-out: "
            + CheckOut.ToString("DD/MM/YYYY")
            + ","
            + Duration() 
            + " nights"; 
        }
    }
}