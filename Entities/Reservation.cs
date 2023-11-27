using System;
using System.Globalization;
using Program.Entities.Exception;

namespace Program.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set;}
        public DateTime CheckOut { get; set; }
        public Reservation()
        {}
        public Reservation(int roomNumber,DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("CheckOut date must be after checkin ");
            }
            RoomNumber = roomNumber; 
            CheckIn = checkIn; 
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan durantion = CheckOut.Subtract(CheckIn);
            return (int)durantion.TotalDays;
        }
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
           DateTime now = DateTime.Now;
           if (checkIn < now || checkOut < now)
           {
                throw new DomainException("Error in reservation dates form : ");           
           } 
           if (checkOut <= checkIn)
           {
                throw new DomainException("CheckOut date must be after checkin ");
           }

           CheckIn = checkIn; 
           CheckOut = checkOut;
        }
        public override string ToString()
        {
            return "Room: " 
            + RoomNumber
            + " Check-in: "
            + CheckIn.ToString("dd/MM/yyyy")
            + " Check-out: " 
            + CheckOut.ToString("dd/MM/yyyy")
            + " , "
            + Duration() 
            + " nights: "; 
        }
    }
}