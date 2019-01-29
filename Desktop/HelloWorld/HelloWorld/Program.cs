using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!!!");
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
