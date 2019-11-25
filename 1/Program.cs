using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Input X");
            while (!double.TryParse(Console.ReadLine(), out x));
            y = ((Math.Sin(x) * 9) * Math.Cos(x) / 11) / Math.Sin(x) + Math.Sin(x) / 2;//y = ((sin(x) * y) * cos(x) / 11)/sin(x) + sin(x)/2;
            Console.WriteLine($"Function number - 1, Value X = {x}, Value Y = {y} ");
        }
    }
}