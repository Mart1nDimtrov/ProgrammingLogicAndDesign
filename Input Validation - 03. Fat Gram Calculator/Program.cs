using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Validation___03.Fat_Gram_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the number of fat grams in the item:");
            var fatGrams = double.Parse(Console.ReadLine());
            while (InvalidGrams(fatGrams))
            {
                Console.WriteLine("Please enter a valid number for the fat grams:");
                fatGrams = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter the number of calories in the item:");
            var calories = double.Parse(Console.ReadLine());
            while (InvalidCalories(calories))
            {
                Console.WriteLine("Please enter a valid number for the calories:");
                calories = double.Parse(Console.ReadLine());
            }

            var percentage = CalcPercent(fatGrams, calories);
            if (percentage < 0.3)
            {
                Console.WriteLine("The percentage is: {0:F2}", percentage);
                Console.WriteLine("The food is low in fat.");
            }
            else
            {
                Console.WriteLine("The percentage is: {0:F2}", percentage);
            }


        }
        static bool InvalidGrams(double fatGrams)
        {
            bool check = false;
            if (fatGrams < 0 )
            {
                check = true;
            }
            return check;
        }
        static bool InvalidCalories(double calories)
        {
            bool check = false;
            if (calories < 0)
            {
                check = true;
            }
            return check;
        }

        static double CalcPercent (double grams, double calories)
        {
            var percent = (grams * 9) / calories;
            return percent;
        }

    }
}
