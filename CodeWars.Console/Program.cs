using System;

namespace CodeWars.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetPins();
        }

        private static void GetPins()
        {
            foreach (var item in ConsoleApp.GetPins.GetPINs("123"))
            {
                Console.WriteLine(item);
            }
        }
    }
}
