using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
   public static class Extensions
    {
        public static double GetInput()
        {
            double x;

            while (true)
            {
                while (!double.TryParse(Console.ReadLine(), out x));
                    return x; 
            }
        }
        public static double GetY(double x)
        {
            if (x < -7 || x > 3)
            {
                throw new ArgumentOutOfRangeException("Argument value should be in arrange [-7; 3]", nameof(x));
            }

            if (x >= -7 && x <= -6)
            {
                return 2;
            }
            else if (x > -6 && x <= -2)
            {
                return ((x + 2) / 4);
            }
            else if (x > -2 && x <= 0)
            {
                return (-(Math.Sqrt(4 - Math.Pow((x + 2), 2))) + 2);
            }
            else if (x > 0 && x <= 2)
            {
                return (Math.Sqrt(4 - Math.Pow(x, 2)));
            }
            else
            {
                return (2 - x);
            }
        }
    }
}
