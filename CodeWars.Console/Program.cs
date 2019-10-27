using System;

namespace CodeWars.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in GetPins.GetPINs("123"))
            {
                Console.WriteLine(item);
            }
        }

    }
}
