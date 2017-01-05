using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions___06.Kinetic_Engergy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the objects's mass and velocity on seperate lines, velocity first:");
            var velocity = int.Parse(Console.ReadLine());
            var mass = int.Parse(Console.ReadLine());

            Console.WriteLine("The object's kinetic engergy is: {0}", KineticEnergy(velocity, mass) );
        }
        static string KineticEnergy (int velocity, int mass)
            {
            var kineticE = 0.5 * mass * (velocity * velocity);
            return Convert.ToString(kineticE);
            }

    }
}
