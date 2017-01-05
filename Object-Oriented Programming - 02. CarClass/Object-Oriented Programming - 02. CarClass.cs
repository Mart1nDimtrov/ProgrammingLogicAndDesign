/*
2. CarClass
Design a class named Carthat has the following fields:
● yearModel: The yearModelfield is an Integerthat holds the car’s year model.
● make: The makefield references a Stringthat holds the make of the car.
● speed: The speedfield is an Integerthat holds the car’s current speed.
In addition, the class should have the following constructor and other methods:
● Constructor: The constructor should accept the car’s year model and make as
arguments. These values should be assigned to the object’s yearModeland make
fields. The constructor should also assign 0 to the speedfield.
● Accessors: Design appropriate accessor methods to get the values stored in an
object’s yearModel, make, and speedfields.
● accelerate: The acceleratemethod should add 5 to the speedfield each
time it is called.
● brake: The brakemethod should subtract 5 from the speedfield each time it is
called.
Next, design a program that creates a Carobject, and then calls the accelerate
method five times. After each call to the acceleratemethod, get the current
speed of the car and display it. Then call the brakemethod five times. After each
call to the brakemethod, get the current speed of the car and display it.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming___02.CarClass
{
    public class Car
    {
        private int yearModel;
        private string make;
        private int speed;

        public Car(int year, string make) // structs don't have a type
        {
            this.yearModel = year;
            this.make = make;
            this.speed = 0;
        }

        public void setYearModel(int year)
        {
            this.yearModel = year;
        }

        public void setMake(string make)
        {
            this.make = make;
        }

        public void setSpeed(int speed)
        {
            this.speed = speed;
        }

        public int getYearModel()
        {
            return this.yearModel;
        }

        public string getMake()
        {
            return this.make;
        }

        public int getSpeed()
        {
            return this.speed;
        }


        public void Accelerate()
        {
            this.speed += 5;
        }

        public void Break()
        {
            this.speed -= 5;
        }




    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(1995, "Sedan");
            var time = 5;

            for (int i = 0; i < time; i++)
            {
                car.Accelerate();
                Console.WriteLine("The cars is moving with {0} mph.", car.getSpeed());
            }
            Console.WriteLine();
            for (int i = 0; i < time; i++)
            {
                car.Break();
                Console.WriteLine("The cars is moving with {0} mph.", car.getSpeed());
            }

        }
    }
}
