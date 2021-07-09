using System;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Lion lion = new Lion("Brown", 6);

            lion.GetDescription();

            Console.WriteLine("Hello World!");
        }
    }
}
