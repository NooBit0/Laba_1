using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Input X.(Valid range x[-7;3])");
            x = Extensions.GetInput();
            try
            {
                y = Extensions.GetY(x);
                Console.WriteLine($"Value X = {x}, Y = {y}");
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.ReadKey();
        }
    }
}