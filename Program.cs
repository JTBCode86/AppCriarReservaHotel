using System;
using AppCriarReservaHotel.Entities;
using AppCriarReservaHotel.Entities.Exceptions;

namespace AppCriarReservaHotel
{
    /// <summary>
    /// Exercicio - tratamento de Exceção
    /// try cath com boas práticas e criação de exceptions.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-In date (dd/mm/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-Out date (dd/mm/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation: ");

                Console.Write("Check-In date (dd/mm/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-Out date (dd/mm/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
                Console.ReadLine();
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
                Console.ReadLine();
            }
            catch (Exception e) 
            {
                Console.WriteLine("Unexpected error: " + e.Message);
                Console.ReadLine();
            }
        }
    }
}
