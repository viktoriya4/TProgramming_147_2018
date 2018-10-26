using System;

namespace laba2
{
    class Program
    {
        public static double y(double x, double a, double b)
        {
            return ((Math.Pow(b, 3) + Math.Pow(Math.Sin(a * x), 2))) / (Math.Acos(x * b) + Math.Exp(-x / 2));
        }

        static void Main(string[] args)
        {
            double a = 1.2;
            double b = 0.48;
            double xn = 0.7;
            double xk = 2.2;
            double dx = 0.3;

            double[] x = new double[5] { 4.48, 3.56, 2.78, 5.28, 3.21 };

            Console.WriteLine("Задача A:");

            for (double xl = xn; xl < xk; xl += dx)
            {
                Console.WriteLine($"Для x = {xl}\t y = {y(xl, a, b):f3}");
            }

            Console.WriteLine("Задача B:");

            foreach (double i in x)
            {
                Console.WriteLine($"Для x = {i}\t y = {y(i, a, b):f3}");
            }
        }
    }
}
