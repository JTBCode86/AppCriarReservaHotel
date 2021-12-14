using System;
using System.Globalization;
using AppCriarReservaHotel.Entities;

namespace AppCriarReservaHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in date (dd/mm/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/mm/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkout<=checkin)
            {
                Console.WriteLine("Error in reservation: check-out must be after check-in!");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation: ");
                
                Console.Write("Check-in date (dd/mm/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/mm/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                string error = reservation.UpdateDates(checkin,checkout);
                if (error != null)
                {
                    Console.WriteLine("Error in reservation "+ error);
                }
                else
                {
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
            Console.ReadLine();
        }
    }
}
