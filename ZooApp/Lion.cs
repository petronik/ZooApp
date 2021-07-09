using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Lion : IAnimal
    {
        public static string ManeColour = "Brown";


        public int Age { get; set; }
        public string Species => GetType().Name;

        public Lion(string maneColor = "No Color", int age = 0)
        {
            ManeColour = maneColor;
            Age = age;

        }

        public void GetDescription()
        {
            Console.WriteLine($"Cage 1 contains a {Age}-year-old {Species} with a {Lion.ManeColour} ");
        }

        public void RequestUniqueCharacteristic()
        {
            if (Lion.ManeColour == null )
            {
                Console.Write("What is the animal's species?");
                ManeColour = Console.ReadLine();
            }
        }
    }
}
