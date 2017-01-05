/*
8. Payroll
Design a program that uses the following parallel arrays:
● empId: An array of seven Integers to hold employee identification numbers.
The array should be initialized with the following numbers:
56588 45201 78951 87775 84512 13028 75804
● hours: An array of seven Integers to hold the number of hours worked by
each employee.
● payRate: An array of seven Reals to hold each employee’s hourly pay rate.
● wages: An array of seven Reals to hold each employee’s gross wages.
The program should relate the data in each array through the subscripts. For 
example, the number in element 0 of the hoursarray should be the number of
hours worked by the employee whose identification number is stored in element 
0 of the empIdarray. That same employee’s pay rate should be stored in element 
0 of the payRatearray.
The program should display each employee number and ask the user to enter that
employee’s hours and pay rate. It should then calculate the gross wages for that
employee (hours times pay rate), which should be stored in the wagesarray. After
the data has been entered for all the employees, the program should display each
employee’s identification number and gross wages.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays___08.Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = 7;
            var empID = new int[] { 56588, 45201, 78951, 87775, 84512, 13028, 75804, };
            var hours = new int[length];
            var payRate = new double[length];
            var wages = new double[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Employee {0}", empID[i]);
                Console.WriteLine("Please enter the hours worked for the employee:");
                var hour = int.Parse(Console.ReadLine());
                hours[i] = hour;
                Console.WriteLine("Please enter the pay rate for the employee:");
                var pay = double.Parse(Console.ReadLine());
                payRate[i] = pay;
                wages[i] = hour * pay;
            }

            Console.WriteLine();

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Employee {0} total wages are: {1:F2}$", empID[i], wages[i]);
            }

        }
    }
}
