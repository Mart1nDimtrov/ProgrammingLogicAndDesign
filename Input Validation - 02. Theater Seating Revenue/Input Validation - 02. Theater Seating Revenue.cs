using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Validation___02.Theater_Seating_Revenue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of tickets sold for section A:");
            var ticketsA = int.Parse(Console.ReadLine());
            while (InvalidSeatsA(ticketsA))
            {
                Console.WriteLine("Please enter a valid number for the tickets sold:");
                ticketsA = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Please enter the number of tickets sold for section B:");
            var ticketsB = int.Parse(Console.ReadLine());
            while (InvalidSeatsB(ticketsB))
            {
                Console.WriteLine("Please enter a valid number for the tickets sold:");
                ticketsB = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Please enter the number of tickets sold for section C:");
            var ticketsC = int.Parse(Console.ReadLine());
            while (InvalidSeatsC(ticketsC))
            {
                Console.WriteLine("Please enter a valid number for the tickets sold:");
                ticketsC = int.Parse(Console.ReadLine());
            }

            var ticketsSold = GetTicketsRevenue(ticketsA, ticketsB, ticketsC);
            Console.WriteLine("The total revenue for the theater is: ${0:F2})", ticketsSold);

        }

        static bool InvalidSeatsA(int seatsA)
        {
            bool check = false;
            if (seatsA < 0 || seatsA > 300)
            {
                check = true;
            }
            return check;
        }
        static bool InvalidSeatsB(int seatsB)
        {
            bool check = false;
            if (seatsB < 0 || seatsB > 500)
            {
                check = true;
            }
            return check;
        }
        static bool InvalidSeatsC(int seatsC)
        {
            bool check = false;
            if (seatsC < 0 || seatsC > 200)
            {
                check = true;
            }
            return check;
        }
        static int GetTicketsRevenue (int seatsA, int seatsB, int seatsC)
        {
            var gross = (20 * seatsA) + (15 * seatsB) + (10 * seatsC);
            return gross;
        }
    }
}
