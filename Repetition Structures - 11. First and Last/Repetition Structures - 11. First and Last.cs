/*
11. First and Last
Design a program that asks the user for a series of names (in no particular order).
After the final person’s name has been entered, the program should display the
name that is first alphabetically and the name that is last alphabetically. 
For example, if the user enters the names Kristin, Joel, Adam, Beth, Zeb, and Chris, the program would display Adam and Zeb.
*/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_Last
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of names or write 'exit':");

            var listNames = new List<string>();
            var name = "";
            var firstName = "";
            var lastName = "";

            while (name != "exit")
            {
                name = Console.ReadLine();
                if (name != "exit")
                {
                    listNames.Add(name);
                }
                

            }

            for (int i = 0; i < listNames.Count; i++)
            {
                var firstChar = listNames[i][0];
                if (i == 0)
                {
                    firstName = listNames[i];
                    lastName = listNames[i];
                }
                else
                {
                    if (firstChar < firstName[0])
                    {
                        firstName = listNames[i];
                    }
                    if (firstChar > lastName[0])
                    {
                        lastName = listNames[i];
                    }
                }
                
            }
            Console.WriteLine("The first name is {0}", firstName);
            Console.WriteLine("The last name is {0}", lastName);


        }
    }
}
