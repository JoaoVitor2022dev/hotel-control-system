using System;
using System.Globalization;
using Program.Entities;
using Program.Entities.Exception;

namespace Primeiro
{
    class Program
    {
        static void Main()
        {
          try
          {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in: (DD/MM/YYYY) ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out: (DD/MM/YYYY) ");
            DateTime checkout = DateTime.Parse(Console.ReadLine()); 

            Reservation reservation = new Reservation(number, checkin, checkout);
            Console.WriteLine("Resavation: " + reservation);

            Console.Write("Check-in: (DD/MM/YYYY) ");
            checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out: (DD/MM/YYYY) ");
            checkout = DateTime.Parse(Console.ReadLine());

            reservation.UpdateDates(checkin, checkout);
            Console.WriteLine("Resavation: " + reservation);
          }
          catch (DomainException e)
          {
            Console.WriteLine($"Error in resevation: {e.Message}");
          }
          catch (FormatException e)
          {
            Console.WriteLine($"Format error: {e.Message}");
          }
          catch (Exception e)
          {
             Console.WriteLine($"Unexpected error: {e.Message}");
          }
        }
   }
}

