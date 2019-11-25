using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double xFirst, xSecond, y, step;

            Console.WriteLine("Input X'begin.(Valid range x[-7;3]");
            xFirst = Task2.Extensions.GetInput();

            Console.WriteLine("Input X'end.(Valid range x[-7;3]");
            xSecond = Task2.Extensions.GetInput();

            Console.WriteLine("Input Step");
            while (!double.TryParse(Console.ReadLine(), out step) || step < 0) ;
            GetCap();
            for (; xFirst <= xSecond; xFirst += step)
            {
                try
                {
                    y = Task2.Extensions.GetY(xFirst);
                    GetRow(xFirst, xSecond, y, step);
                }
                catch (ArgumentException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            Console.WriteLine("----------------------------------------");
        }

        private static void GetCap()
        {
            Console.WriteLine("-Step---X'begin---X'end---Y---");
        }
        private static void GetRow(double xFirst, double xSecond, double y, double step) =>
            Console.WriteLine("  {0,-6} {1,-9:0.00} {2,-5:0.00} {3,-7:0.00}", step, xFirst, xSecond, y);
    }
}
