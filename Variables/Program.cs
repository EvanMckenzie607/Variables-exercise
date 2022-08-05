using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Scottie";
            int dogAge = 15;
            char dogToy = '3';
                bool b1 = true;
            bool b2 = false;
            double dub1 = 5;
            decimal dec1 = 99.99m;

            Console.WriteLine($"My dogs name is {dogName}");
            Console.WriteLine($"{dogName} is {dogAge} years old");
            Console.WriteLine($"{b1} or {b2}");
            Console.WriteLine($"Do i love {dogName}");
            Console.WriteLine($"{b1} yes i do {dogName} is a good boy");
            Console.WriteLine($"My {dogName} has {dogToy} Kongs");
            Console.WriteLine($"{dogName} has at least {dub1} poker buddies");
            Console.WriteLine($"{dogName} owes me ${dec1}!");


            
        }
    }
}
