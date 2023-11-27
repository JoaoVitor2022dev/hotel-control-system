using System;
using System.Globalization;
using Program.Entities;

namespace Primeiro
{
    class Program
    {
        static void Main()
        {
            // entrada de dados 

            Console.WriteLine("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in: (DD/MM/YYYY) ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-Out: (DD/MM/YYYY) ");
            DateTime checkout = DateTime.Parse(Console.ReadLine()); 
           
            // processsamento de dados  

            if (checkin < checkout)
            {
                Console.WriteLine("Error in reservation dates form : ");
            } 
            else 
            {
                Reservation reservation = new Reservation(number, checkin, checkout);

                Console.Write("Check-in: (DD/MM/YYYY) ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-Out: (DD/MM/YYYY) ");
                checkout = DateTime.Parse(Console.ReadLine()); 

                DateTime now = DateTime.Now; 
                if (checked < now || checkout < now )
                {
                    Console.WriteLine("Error in reservation dates form : ");
                } 
                else 
                {
                    reservation.UpdateDates(checkin, checkout);
                    Console.WriteLine("Resevation: " + reservation);
                }
            }
        }
   }
}

