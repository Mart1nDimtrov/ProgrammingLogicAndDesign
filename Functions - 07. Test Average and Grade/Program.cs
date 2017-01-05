using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function___07.Test_Average_and_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter five grades on seperate lines:");
            var firstGrade = int.Parse(Console.ReadLine());
            Console.WriteLine(determineGrade(firstGrade));
            var secondGrade = int.Parse(Console.ReadLine());
            Console.WriteLine(determineGrade(secondGrade));
            var thirdGrade = int.Parse(Console.ReadLine());
            Console.WriteLine(determineGrade(thirdGrade));
            var fourthGrade = int.Parse(Console.ReadLine());
            Console.WriteLine(determineGrade(fourthGrade));
            var fifthGrade = int.Parse(Console.ReadLine());
            Console.WriteLine(determineGrade(fifthGrade));

            Console.WriteLine("The average is: {0}", calcAverage(firstGrade, secondGrade, thirdGrade, 
                fourthGrade, fifthGrade));

        }
        static int calcAverage (int first, int second, int third, int fourth, int fifth)
        {
            var average = (first + second + third + fourth + fifth) / 5;
            return average;
        }
        static string determineGrade (int grade)
        {
            var gradeLetter = "";
            if (grade >= 90 && grade <= 100)
            {
                gradeLetter = "A";
            }
            else if (grade < 90 && grade >= 80)
            {
                gradeLetter = "B";
            }
            else if (grade < 80 && grade >= 70)
            {
                gradeLetter = "C";
            }
            else if (grade < 70 && grade >= 60)
            {
                gradeLetter = "D";
            }
            else
            {
                gradeLetter = "F";
            }
            return gradeLetter;
        }
    }
}
