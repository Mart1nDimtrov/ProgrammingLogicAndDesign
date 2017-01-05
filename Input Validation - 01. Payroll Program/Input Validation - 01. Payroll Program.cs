using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Validation___01.Payroll_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of hours the employee has worked:");
            var hours = int.Parse(Console.ReadLine());
            while (InvalidHours(hours))
            {
                Console.WriteLine("Error: Invalid hours.");
                Console.WriteLine("Please enter the number of hours the employee has worked:");
                hours = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Please enter the employee's hourly pay rate:");
            var payRate = double.Parse(Console.ReadLine());
            while (InvalidPay(payRate))
            {
                Console.WriteLine("Error: Invalid payrate.");
                Console.WriteLine("Please enter the employee's hourly pay rate:");
                payRate = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("The employee's gross pay is: ${0:F2}", payRate * hours);

        }
        static bool InvalidHours (int hours)
        {
            bool check = false;
            if (hours < 0 || hours > 40)
            {
                check = true;
            }
            return check;
        }
        static bool InvalidPay(double payrate)
        {
            bool check = false;
            if (payrate < 7.50 || payrate > 18.25)
            {
                check = true;
            }
            return check;
        }
    }
}
