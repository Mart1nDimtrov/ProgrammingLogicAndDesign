/*
4. Employee and ProductionWorker Classes
Design an Employeeclass that has fields for the following pieces of information:
● Employee name
● Employee number
Next, design a class namedProductionWorkerthat extends the Employeeclass.
The ProductionWorkerclass should have fields to hold the following information:
● Shift number (an integer, such as 1, 2, or 3)
● Hourly pay rate
The workday is divided into two shifts: day and night. The shift field will hold an
integer value representing the shift that the employee works. The day shift is shift 1
and the night shift is shift 2. Design the appropriate accessor and mutator methods
for each class.
Once you have designed the classes, design a program that creates an object of the
ProductionWorkerclass and prompts the user to enter data for each of the object’s fields. Store the data in the object and then use the object’s accessor methods
to retrieve it and display it on the screen.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming___04.Employee_Class
{
    class Employee
    {
        private string name;
        private string number;

        public Employee()
        {
           
        }
        public Employee(string name, string number)
        {
            this.name = name;
            this.number = number;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setNumber(string number)
        {
            this.number = number;
        }
        public string getName()
        {
            return this.name;
        }
        public string getNumber()
        {
            return this.number;
        }

    }

   class ProductionWorker : Employee
    {
        private int shiftNumber;
        private int hourlyPayRate;

        public ProductionWorker () {

            }

        public ProductionWorker(int shiftNumber, int payRate)
        {
            this.shiftNumber = shiftNumber;
            this.hourlyPayRate = payRate;
        }

        public void setPayRate(int payRate)
        {
            this.hourlyPayRate = payRate;
        }
        public void setShiftNumber(int shiftNumber)
        {
            this.shiftNumber = shiftNumber;
        }

        public int getPayRate()
        {
            return this.hourlyPayRate;
        }
        public int getShiftNumber()
        {
            return this.shiftNumber;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            ProductionWorker Tim = new ProductionWorker(1, 10);
            Tim.setName("Tim");
            Tim.setNumber("8805");
            Console.WriteLine("The worker's name is {0}", Tim.getName());
            Console.WriteLine("His number is {0}", Tim.getNumber());
            Console.WriteLine("He works the {0} shift.", Tim.getShiftNumber() == 1 ? "day" : "night");
            Console.WriteLine("He gets {0}$ an hour.", Tim.getPayRate());
        }
    }
}
