/*
1. PetClass
Design a class named Pet, which should have the following fields:
● name: The namefield holds the name of a pet.
● type: The typefield holds the type of animal that a pet is. Example values are
"Dog", "Cat", and "Bird".
● age: The agefield holds the pet’s age.
The Petclass should also have the following methods:
● setName: The setNamemethod stores a value in the namefield.
● setType: The setTypemethod stores a value in the typefield.
● setAge: The setAgemethod stores a value in the agefield.
● getName: The getNamemethod returns the value of the namefield.
● getType: The getTypemethod returns the value of the typefield.
● getAge: The getAgemethod returns the value of the agefield.
Once you have designed the class, design a program that creates an object of the
class and prompts the user to enter the name, type, and age of his or her pet. This
data should be stored in the object. Use the object’s accessor methods to retrieve
the pet’s name, type, and age and display this data on the screen.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming___01.Pet_Class
{
    public class Pet
    {
        private string name;
        private string type;
        private string age;

        public void setName (string name)
        {
            this.name = name;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public void setAge(string age)
        {
            this.age = age;
        }

        public string getName()
        {
            return this.name;
        }

        public string getType()
        {
            return this.type;
        }

        public string getAge()
        {
            return this.age;
        }




    }
    class Program
    {
        static void Main(string[] args)
        {
            Pet myPet = new Pet();
            Console.WriteLine("Please enter the name, type, and age of your pets on seperate lines:");
            var name = Console.ReadLine();
            var type = Console.ReadLine();
            var age = Console.ReadLine();

            myPet.setName(name);
            myPet.setType(type);
            myPet.setAge(age);

            Console.WriteLine("Your pet's name is {0}", myPet.getName());
            Console.WriteLine("Your pet is a {0}", myPet.getType());
            Console.WriteLine("And your pet is {0} years old", myPet.getAge());
        }
    }
}
