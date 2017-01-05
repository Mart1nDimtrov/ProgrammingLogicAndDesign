using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Validation___04.Speeding_Violation_Calc
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Please enter the speed limit:");
                var speedLimit = int.Parse(Console.ReadLine());
                while (InvalidSpeedLimit(speedLimit))
                {
                    Console.WriteLine("Please enter a valid speed limit:");
                    speedLimit = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Please enter the driver's speed:");
                var driverSpeed = int.Parse(Console.ReadLine());
                while (InvalidSpeed(speedLimit, driverSpeed))
                {
                    Console.WriteLine("Please enter a valid speed:");
                 driverSpeed = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("The driver was doing {0} mph over the speed limit.", driverSpeed - speedLimit);
              


            }
            static bool InvalidSpeedLimit(int speedLimit)
            {
                bool check = false;
                if (speedLimit < 20 || speedLimit > 70)
                {
                    check = true;
                }
                return check;
            }
            static bool InvalidSpeed(int speedLimit, int speed)
            {
                bool check = false;
                if (speed <= speedLimit)
                {
                    check = true;
                }
                return check;
            }

          

        }
    }

