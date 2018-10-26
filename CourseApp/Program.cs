using System;

namespace ConsoleApp3
{
<<<<<<< HEAD
    public class Program
=======
    class Program
>>>>>>> 3dbf26c1fd86d510f5978fa2327d2ffaef4279bc

    {

        public static double y(double x, double a, double b)
        {
<<<<<<< HEAD
            return Math.Log10(x * x - 1) / Math.Log((a * x * x - b), 5);
=======
            return ((Math.Log10(x * x - 1) / Math.Log((a * x * x - b), 5)));
>>>>>>> 3dbf26c1fd86d510f5978fa2327d2ffaef4279bc
        }


        static void Main()
        {
            double a = 1.1;
            double b = 0.09;

            double[] x1 = new double[5] { 1.21, 1.76, 2.53, 3.48, 4.52 };

            Console.WriteLine("Задача A:");

            for (double x = 1.2; x <= 2.2; x = x + 0.2)
            {
                Console.WriteLine($"На шаге {x} функция y = {Math.Round(y(x,a,b), 4)}");
            }

            Console.WriteLine("Задача B:");

            foreach (double i in x1)

            {
                Console.WriteLine($"Для x = {i}\t y = {y(i, a, b)}");
            }
            Console.ReadKey();
        }

    }
}
