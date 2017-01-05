/*
3. Personal Information Class
Design a class that holds the following personal data: name, address, age, and
phone number. Write appropriate accessor and mutator methods. Also, design a
program that creates three instances of the class. One instance should hold your
information, and the other two should hold your friends’ or family members’
information.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming___03.P.Info_Class
{
    class PersonalInformation
    {
        private string name;
        private string adress;
        private int age;
        private string phoneNumber;

        public PersonalInformation()
        {
            // we need an empty constructor to initialize a new instance of the class without values
        }
        public PersonalInformation (string name, string adress, int age, string phoneNumber){
            this.name = name;
            this.adress = adress;
            this.age = age;
            this.phoneNumber = phoneNumber;

        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setAdress(string adress)
        {
            this.adress = adress;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public string getName()
        {
            return this.name;
        }
        public string getAdress()
        {
            return this.adress;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            PersonalInformation Katherina = new PersonalInformation("Katherina", "1107 Lower Kirklington Road, Southwell",
                57, "+4491 4120 5694");

            PersonalInformation Maata = new PersonalInformation("Maata", "3174 Rocky Rabbit Byway",
                66, "(401) 803-1860");

            PersonalInformation Avantika = new PersonalInformation("Avantika", "2172 Cinder Berry Crest",
                44, "(253) 109-9079");
        }
    }
}
